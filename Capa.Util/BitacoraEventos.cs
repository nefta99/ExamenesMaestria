using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using System.Diagnostics;

namespace Capa.Util
{
    public class BitacoraEventos
    {
        //Definicion de propiedades
        private BitacoraEventos _bitacora;

        //Constructor
        private BitacoraEventos()
        {

        }
        private BitacoraEventos Bitacora()
        {
            if (_bitacora == null)
            {
                _bitacora = new BitacoraEventos();
            }
            return _bitacora;
        }
        //metodos
        public static void InsertaEvento(string p_UsurioId, string p_proceso, string p_accion, string p_informacion)
        {
            try
            {
                //pasamos los datos a Nlog para que inserte en la base de datos
                var logger = LogManager.GetCurrentClassLogger();
                LogEventInfo theEvent = new LogEventInfo(LogLevel.Info, "", "");
                theEvent.Properties["UsuarioId"] = p_UsurioId;
                theEvent.Properties["Proceso"] = p_proceso;
                theEvent.Properties["Accion"] = p_accion;
                theEvent.Properties["Informacion"] = p_informacion;
                logger.Log(theEvent);

            }
            catch (Exception es)
            {
                Console.WriteLine(es.Message);
            }

        }
        public static void InsertaError(string clase, string metodo, string info, string exceptiomsg, string User)
        {
            //Este evento insertará en el eventviewwer del servidor en indicativo de error.
            try
            {
                var logger = LogManager.GetCurrentClassLogger();

                LogEventInfo theEvent = new LogEventInfo(LogLevel.Info, "", "");
                theEvent.Properties["UsuarioId"] = User;
                theEvent.Properties["Proceso"] = clase;
                theEvent.Properties["Accion"] = metodo;
                theEvent.Properties["Informacion"] = info + " --  " + exceptiomsg;
                logger.Log(theEvent);
            }
            catch (Exception e)
            {
                using (EventLog eventLog = new EventLog("Application"))
                {
                    eventLog.Source = "SAMP Application";
                    eventLog.WriteEntry((e.Message == null ? "" : e.Message) + " - " + (e.InnerException == null ? "" : e.InnerException.ToString()) + " - " + (e.StackTrace == null ? "" : e.StackTrace.ToString()), EventLogEntryType.Error, 101, 1);
                }

                //    EscribirErrorLogFile("Util_Bitacora", "InsertaError", "No escribe en log", (e.Message == null ? "" : e.Message) + " - " + (e.InnerException == null ? "" : e.InnerException.ToString()) + " - " + (e.StackTrace == null ? "" : e.StackTrace.ToString()),0, "MNO_ADMIN","Bitacora.mno");
            }


        }
    }
}
