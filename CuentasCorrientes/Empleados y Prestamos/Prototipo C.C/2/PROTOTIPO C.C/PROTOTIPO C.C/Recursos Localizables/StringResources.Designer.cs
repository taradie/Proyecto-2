﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PROTOTIPO_C.C.Recursos_Localizables {
    using System;
    
    
    /// <summary>
    ///   Clase de recurso fuertemente tipado, para buscar cadenas traducidas, etc.
    /// </summary>
    // StronglyTypedResourceBuilder generó automáticamente esta clase
    // a través de una herramienta como ResGen o Visual Studio.
    // Para agregar o quitar un miembro, edite el archivo .ResX y, a continuación, vuelva a ejecutar ResGen
    // con la opción /str o recompile su proyecto de VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class StringResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal StringResources() {
        }
        
        /// <summary>
        ///   Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PROTOTIPO_C.C.Recursos_Localizables.StringResources", typeof(StringResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Reemplaza la propiedad CurrentUICulture del subproceso actual para todas las
        ///   búsquedas de recursos mediante esta clase de recurso fuertemente tipado.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Aceptar.
        /// </summary>
        public static string ButtonLabel1 {
            get {
                return ResourceManager.GetString("ButtonLabel1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Clientes.
        /// </summary>
        public static string MenuClientes {
            get {
                return ResourceManager.GetString("MenuClientes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Español.
        /// </summary>
        public static string rbEspanol {
            get {
                return ResourceManager.GetString("rbEspanol", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Ingles.
        /// </summary>
        public static string rbIngles {
            get {
                return ResourceManager.GetString("rbIngles", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Seleccione el idioma que desea utilizar en el sistema:.
        /// </summary>
        public static string String1 {
            get {
                return ResourceManager.GetString("String1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Idioma.
        /// </summary>
        public static string TituloGrupo {
            get {
                return ResourceManager.GetString("TituloGrupo", resourceCulture);
            }
        }
    }
}
