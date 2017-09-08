using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfS_UNIVO_APP_Android
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class 
    // name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, 
    // please select Service1.svc or Service1.svc.cs at the Solution Explorer and start 
    // debugging.
    public class Service1 : IService1
    {
     
        /// <summary>
        /// Loguear al estudiante
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="clave"></param>
        /// <returns></returns>
        public String ComprobarEstudiante(String usuario, String clave)
        {
            if(usuario == "U20120453" && clave == "12345")
            {
                return OperationContext.Current.SessionId;
            }
            return "NoId";
        }

        /// <summary>
        /// Debe retornar aulas materias y horas
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="clave">Con el objeto de comprobar cada que necesite datos
        /// de la cuenta</param>
        /// <returns></returns>
        public Boolean MateriasInscritas(String carnet, String clave){
            return true;
        }

        /// <summary>
        /// Obtendra las notas de laboratorios, parciales, reposiciones, nota final
        /// </summary>
        /// <param name="carnet"></param>
        /// <param name="clave"></param>
        public void Notas(String carnet, String clave) {

        }

        /// <summary>
        /// Los pagos realizados del ciclo activo supongo.
        /// </summary>
        /// <param name="carnet"></param>
        /// <param name="clave"></param>
        public void PagosRealizados(String carnet, String clave) { }

        /// <summary>
        /// Los datos del perfil de estudiante, nose si seria apropiado que envie tambien
        /// la imagen del estudiante.
        /// </summary>
        /// <param name="carnet"></param>
        /// <param name="clave"></param>
        /// <returns></returns>
        public void PerfilEstudiante(String carnet, String clave) { }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public void SegruridadPorControlGranular()
        {
            throw new NotImplementedException();
        }
    }
}
