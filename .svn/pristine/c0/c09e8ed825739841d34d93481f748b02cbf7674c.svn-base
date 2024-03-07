using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace INFIT.docs
{
    class ManipulaData
    {
        public static string HORA_INICIAL = "00:00";
        public static string HORA_FINAL = "23:59";

        public static string FormatarData(DateTime data, string HORA)
        {
            return data.Year + "-" + data.Month + "-" + data.Day + " " + HORA;
        }

        public static string FormatarData(DateTime data)
        {
            return data.Hour + "_" + data.Minute + "_" + data.Second + "_" + data.Day + "_" + data.Month + "_" + data.                       Year;
        }

        public static string FormatarDataMensal(DateTime data, string dia, string HORA)
        {
            return data.Year + "-" + data.Month + "-" + dia + " " + HORA;
        }

        public static DateTime AdicionarUmMes(DateTime data)
        {
            int mes = data.Month + 1;
            return new DateTime(data.Year, mes, data.Day);
        }

        public static bool SenhaExpirada(DateTime data)
        {
            int compare = DateTime.Compare(data, DateTime.Now);
            if (compare > 0)
                return false;
            else
                return true;
        }
    }
}
