using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace PhasmoHelper
{
    /// <summary>
    /// Класс для чтения/записи INI-файлов
    /// </summary>
    public class INIManager
    {
        /// <summary>
        /// Конструктор, принимающий путь к INI-файлу
        /// </summary>
        /// <param name="aPath"></param>
        public INIManager(string aPath)
        {
            path = aPath;
        }

        /// <summary>
        /// Конструктор без аргументов (путь к INI-файлу задается отдельно)
        /// </summary>
        public INIManager() : this("") { }

        /// <summary>
        /// Позвращает значение по данному ключу секции
        /// </summary>
        /// <param name="aSection"></param>
        /// <param name="aKey"></param>
        /// <returns></returns>
        public string GetPrivateString(string aSection, string aKey)
        {
            StringBuilder buffer = new StringBuilder(SIZE);
            GetPrivateString(aSection, aKey, null, buffer, SIZE, path);
            return buffer.ToString();
        }

        /// <summary>
        /// Записывает значение в данный ключ секции
        /// </summary>
        /// <param name="aSection"></param>
        /// <param name="aKey"></param>
        /// <param name="aValue"></param>
        public void WritePrivateString(string aSection, string aKey, string aValue)
        {
            WritePrivateString(aSection, aKey, aValue, path);
        }

        /// <summary>
        /// Удаляет ключ из секции
        /// </summary>
        /// <param name="Key"></param>
        /// <param name="Section"></param>
        public void DeleteKey(string Key, string Section = null)
        {
            WritePrivateString(Section, Key, null);
        }

        /// <summary>
        /// Удаляет секцию
        /// </summary>
        /// <param name="Section"></param>
        public void DeleteSection(string Section = null)
        {
            WritePrivateString(Section, null, null);
        }

        /// <summary>
        /// Проверяет, существует ли ключ в данной секции
        /// </summary>
        /// <param name="Section"></param>
        /// <param name="Key"></param>
        /// <returns>true - существует, false - не существует</returns>
        public bool KeyExists(string Section, string Key)
        {
            return GetPrivateString(Section, Key).Length > 0;
        }

        /// <summary>
        /// Возвращает или устанавливает путь к INI файлу
        /// </summary>
        public string Path { get { return path; } set { path = value; } }

        // Поля класса
        private const int SIZE = 1024; // Максимальный размер (для чтения значения из файла)
        private string path = null; // Для хранения пути к INI-файлу

        // Импорт функции GetPrivateProfileString (для чтения значений) из библиотеки kernel32.dll
        [DllImport("kernel32.dll", EntryPoint = "GetPrivateProfileString")]
        private static extern int GetPrivateString(string section, string key, string def, StringBuilder buffer, int size, string path);

        // Импорт функции WritePrivateProfileString (для записи значений) из библиотеки kernel32.dll
        [DllImport("kernel32.dll", EntryPoint = "WritePrivateProfileString")]
        private static extern int WritePrivateString(string section, string key, string str, string path);
    }
}