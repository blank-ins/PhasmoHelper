using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhasmoHelper
{
    /// <summary>
    /// Содержит данные о призраке: имя, описание
    /// </summary>
    public struct Ghost
    {
        public string type;
        public string name;
        public string[] evidence;
        public string description;


        /// <summary>
        /// Проверяет, совпадают ли введённый тип с типом призрака.
        /// </summary>
        /// <param name="inType"></param>
        /// <returns></returns>

        public void setEvidence(string _ev1, string _ev2, string _ev3)
        {
            evidence = new string[3];
            evidence[0] = _ev1;
            evidence[1] = _ev2;
            evidence[2] = _ev3;
        }
    }

    class think
    {
        // 12 типов призраков: Банши, Ревенант, Фантом, Они, Джинн, Тень, Мираж, Дух, Полтергейст, Демон, Мара, Юрэй
        // Соответсвуют различным 6 уликам, 1 призрак - 3 улики
        // emp print term radio notes orb
        // ЭМП ур. 5, Отпечатки, Минусовая температура, Радиоприёмник, Записи в блокноте, Призрачный огонёк

        private Ghost[] GhostTypes = new Ghost[12];

        // GhostTypes[].name = "";
        // GhostTypes[].type = "";
        // GhostTypes[].setEvidence("", "", "");
        public think()
        {
            //
            // Банши
            //
            GhostTypes[0].name = "Банши";
            GhostTypes[0].type = "banshi";
            GhostTypes[0].setEvidence("emp", "print", "term");
            GhostTypes[0].description =
                "Опасные прирождённые охотники. Они попытаются выследить и по одному устранить охотников за приведениями. " +
                "Банши боятся распятий, что делает эти предметы особенно эффективными в борьбе с ними.";
            //
            // Ревенант
            //
            GhostTypes[1].name = "Ревенант";
            GhostTypes[1].type = "revenant";
            GhostTypes[1].setEvidence("emp", "print", "notes");
            GhostTypes[1].description =
                "Агрессивные призраки, которые могут нападать на всех без разбора и могут посреди охоты переключиться на другую цель. " +
                "При обнаружении начинают медленно двигаться, но как только цель попадёт в поле их зрения, перемещаются быстрее любого другого призрака в игре.";
            //
            // Фантом
            //
            GhostTypes[2].name = "Фантом";
            GhostTypes[2].type = "phantom";
            GhostTypes[2].setEvidence("emp", "term", "notes");
            GhostTypes[2].description =
                "Призраки, внушающие страх, таким образом быстро истощающие рассудок тех, кто смотрит на них. Если Фантома сфотографировать, " +
                "он ненадолго исчезнет. Хотя ходят слухи, что они могут вселяться в живых, на самом деле Фантомы такой способностью не обладают. " +
                "Считается, что их можно запросто вызвать при помощи доски Уиджи, однако игроки не могут призывать их сами, также появление фантома не гарантирует появление доски Уиджи на локации.";
            //
            // Они
            //
            GhostTypes[3].name = "Óни";
            GhostTypes[3].type = "oni";
            GhostTypes[3].setEvidence("emp", "radio", "notes");
            GhostTypes[3].description =
                "Агрессивные призраки, чей уровень активности зависит от количества находящихся неподалёку игроков." +
                " Это же становится их наибольшей слабостью, поскольку Они с большой долей вероятности проявят себя на ранних этапах исследования. Часто могут бродить вокруг комнаты призраков.";
            //
            // Джинн
            //
            GhostTypes[4].name = "Джинн";
            GhostTypes[4].type = "jin";
            GhostTypes[4].setEvidence("emp", "radio", "orb");
            GhostTypes[4].description =
                "Территориальные призраки, нападающие в том случае, если почувствуют угрозу. " +
                "Они перемещаются с большой скоростью и используют эту способность для охоты на далеко находящихся игроков. " +
                "Однако их скорость можно ограничить, если отключить электричество при помощи щитка.";
            //
            // Тень
            //
            GhostTypes[5].name = "Тень";
            GhostTypes[5].type = "shadow";
            GhostTypes[5].setEvidence("emp", "notes", "orb");
            GhostTypes[5].description =
                "Тени считаются «застенчивыми» призраками. Признаки их присутствия обнаружить сложнее, если игроки остаются в группе, шансы нападения, как и активность призрака, снижаются.";
            //
            // Мираж
            //
            GhostTypes[6].name = "Мираж";
            GhostTypes[6].type = "mirage";
            GhostTypes[6].setEvidence("print", "term", "radio");
            GhostTypes[6].description =
                "Одни из самых опасных призраков, которые могут встретиться игрокам. " +
                "Единственный тип, обладающий способностью летать. Иногда проходят сквозь стены. Соль токсична для Миражей.";
            //
            // Дух
            //
            GhostTypes[7].name = "Дух";
            GhostTypes[7].type = "spirit";
            GhostTypes[7].setEvidence("print", "radio", "notes");
            GhostTypes[7].description = 
                "Самый распространённый тип призраков. Тем не менее, сильные и опасные. " +
                "Обычно появляются в одном из одержимых ими помещений после необъяснимой смерти. Особыми способностями не обладают.";
            //
            // Полтергейст
            //
            GhostTypes[8].name = "Полтергейст";
            GhostTypes[8].type = "polterheist";
            GhostTypes[8].setEvidence("print", "radio", "orb");
            GhostTypes[8].description =
                "Один из самых известных типов призраков. Полтергейсты — шумные призраки, могут манипулировать многочисленными предметами и вселять страх в своих жертв.";
            //
            // Демон
            //
            GhostTypes[9].name = "Демон";
            GhostTypes[9].type = "demon";
            GhostTypes[9].setEvidence("term", "radio", "notes");
            GhostTypes[9].description =
                "Одни из худших призраков, которых могут повстречать игроки. Будучи крайне агрессивными, " +
                "они будут нападать чаще любых других призраков, поэтому рекомендуется иметь при себе распятие, " +
                "что может предотвратить охоту. Однако, имея дело с Демонами, игроки могут использовать доску Уиджи без большого вреда для рассудка.";
            //
            // Мара
            //
            GhostTypes[10].name = "Мара";
            GhostTypes[10].type = "mara";
            GhostTypes[10].setEvidence("term", "radio", "orb");
            GhostTypes[10].description =
                "Порождающая кошмары Мара становится сильнее в темноте. " +
                "Снизить уровень её агрессивности (но не устранить полностью) можно, поддерживая освещение и оставаясь в освещённых помещениях. " +
                "Игрокам следует оставаться начеку, поскольку Мара будет пытаться выключить свет, чтобы стать сильнее.";
            //
            // Юрэй
            GhostTypes[11].name = "Юрэй";
            GhostTypes[11].type = "urei";
            GhostTypes[11].setEvidence("term", "notes", "orb");
            GhostTypes[11].description =
                "Призраки, чьи способности ускоряют пассивное снижение рассудка игроков. " +
                "Если обработать комнату, в которой были обнаружены Юрэй, " +
                "травами, эти призраки на долгое время лишаться возможности перемещаться по локации.";
        }

        public string[] typeIDN(string[] evidence, int _count)
        {
            string[] types = new string[12];

            switch (_count)
            {
                case 1:
                    for (int i = 0; i < GhostTypes.Length; i++)
                    {
                        if (GhostTypes[i].evidence[0] == evidence[0] || GhostTypes[i].evidence[1] == evidence[0] || GhostTypes[i].evidence[2] == evidence[0]) types[i] = GhostTypes[i].type;
                        else types[i] = "--";
                    }
                    break;
                case 2:
                    for (int i = 0; i < GhostTypes.Length; i++)
                    {
                        if (
                            (GhostTypes[i].evidence[0] == evidence[0] || GhostTypes[i].evidence[1] == evidence[0] || GhostTypes[i].evidence[2] == evidence[0])
                            &
                            (GhostTypes[i].evidence[0] == evidence[1] || GhostTypes[i].evidence[1] == evidence[1] || GhostTypes[i].evidence[2] == evidence[1])
                            ) types[i] = GhostTypes[i].type;
                        else types[i] = "--";
                    }
                    break;
                case 3:
                    for (int i = 0; i < GhostTypes.Length; i++)
                    {
                        if (
                            (GhostTypes[i].evidence[0] == evidence[0] || GhostTypes[i].evidence[1] == evidence[0] || GhostTypes[i].evidence[2] == evidence[0])
                            &
                            (GhostTypes[i].evidence[0] == evidence[1] || GhostTypes[i].evidence[1] == evidence[1] || GhostTypes[i].evidence[2] == evidence[1])
                            &
                            (GhostTypes[i].evidence[0] == evidence[2] || GhostTypes[i].evidence[1] == evidence[2] || GhostTypes[i].evidence[2] == evidence[2])
                            ) types[i] = GhostTypes[i].type;
                        else types[i] = "--";
                    }
                    break;
            }
            return types;
        }

        public string[] evidIDN(string type)
        {
            string[] evidence = new string[3];

            for(int i = 0; i < GhostTypes.Length; i++)
                if (GhostTypes[i].type == type)
                    for (int j = 0; j < evidence.Length; j++) evidence[j] = GhostTypes[i].evidence[j];

            return evidence;
        }

        public string getDescription(string type)
        {
            for(int i = 0; i < GhostTypes.Length; i++)
                if (GhostTypes[i].type == type)
                    return GhostTypes[i].description;
            return null;
        }

        public string KeyCodeName(string KeyCode)
        {
            switch (KeyCode)
            {
                case "D1":
                    return "1";
                case "D2":
                    return "2";
                case "D3":
                    return "3";
                case "D4":
                    return "4";
                case "D5":
                    return "5";
                case "D6":
                    return "6";
                case "D7":
                    return "7";
                case "D8":
                    return "8";
                case "D9":
                    return "9";
                case "D0":
                    return "0";
                case "Oemtilde":
                    return "~";
                case "OemMinus":

                case "Escape":
                    return "Esc";
                    return "-";
                case "Oemplus":
                    return "+";
                case "Capital":
                    return "CAPS";
                case "ShiftKey":
                    return "Shift";
                case "ControlKey":
                    return "Ctrl";
                case "Menu":
                    return "Alt";

                case "OemOpenBrackets":
                    return "[";
                case "Oem6":
                    return "]";
                case "Oem1":
                    return ";";
                case "Oem7":
                    return "'";
                case "Oemcomma":
                    return "<";
                case "OemPeriod":
                    return ">";
                case "OemQuestion":
                    return "?";
                case "Oem5":
                    return "|";

                case "Insert":
                    return "Ins";
                case "Delete":
                    return "Del";
                case "PageUp":
                    return "PgUp";
                case "Next":
                    return "PgDn";

                case "NumPad0":
                    return "Num0";
                case "NumPad1":
                    return "Num1";
                case "NumPad2":
                    return "Num2";
                case "NumPad3":
                    return "Num3";
                case "NumPad4":
                    return "Num4";
                case "NumPad5":
                    return "Num5";
                case "NumPad6":
                    return "Num6";
                case "NumPad7":
                    return "Num7";
                case "NumPad8":
                    return "Num8";
                case "NumPad9":
                    return "Num9";

                case "Decimal":
                    return "Num.";
                case "Return":
                    return "Enter";
                case "Add":
                    return "Num+";
                case "Subtract":
                    return "Num-";
                case "Multiply":
                    return "Num*";
                case "Divide":
                    return "Num/";
                case "NumLock":
                    return "Lock";

                default:
                    return KeyCode;
            }
        }

    }
}
