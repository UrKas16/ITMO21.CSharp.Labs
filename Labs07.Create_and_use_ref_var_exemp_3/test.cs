USING SYSTEM;
USING SYSTEM.COLLECTIONS.GENERIC;
USING SYSTEM.LINQ;
USING SYSTEM.TEXT;
USING SYSTEM.THREADING.TASKS;
USING SYSTEM.IO;

NAMESPACE LABS07.CREATE_AND_USE_REF_VAR
{
    CLASS COPYFILEUPPER
    {
        PUBLIC STATIC VOID MAIN()
        {
            STRING SFROM;
            STRING STO;
            STREAMREADER SRFROM;
            STREAMWRITER SWTO;

            CONSOLE.WRITELINE("ВВЕДИТЕ ИМЯ ФАЙЛА: ");
            SFROM = CONSOLE.READLINE();

            CONSOLE.WRITELINE("ВВЕДИТЕ ИМЯ НОВОГО ФАЙЛА: ");
            STO = CONSOLE.READLINE();

            TRY
            {
                SRFROM = NEW STREAMREADER(SFROM);
                SWTO = NEW STREAMWRITER(STO);

                WHILE (SRFROM.PEEK() != -1)
                {
                    STRING SBUFFER = SRFROM.READLINE();
                    SBUFFER = SBUFFER.TOUPPER();
                    SWTO.WRITELINE(SBUFFER);

                }
                SWTO.CLOSE();
                SRFROM.CLOSE();

            }

            CATCH (FILENOTFOUNDEXCEPTION)
            {
                CONSOLE.WRITELINE("ВХОДЯЩИЙ ФАЙЛ НЕ НАЙДЕН!");
            }
            CATCH (EXCEPTION E)
            {
                CONSOLE.WRITELINE("UNEXPECTED EXCEPTION");
                CONSOLE.WRITELINE(E.TOSTRING());
            }
        
        }

    }
}
