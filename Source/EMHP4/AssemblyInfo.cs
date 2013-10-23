using System;
using System.IO;
using System.Reflection;

namespace EMHP4 {
    internal class AssemblyInfo {

        #region Методы доступа к атрибутам сборки
        readonly Assembly _ea;

        internal AssemblyInfo(Assembly assembly = null) {
            _ea = assembly ?? Assembly.GetExecutingAssembly();
        }

        private string GACA<T>( Func<T, string> conv ) where T : Attribute {
            var attributes = _ea.GetCustomAttributes( typeof( T ), false );
            return attributes.Length == 0 ? "" : ( conv( (T) attributes[ 0 ] ) );
        }
        internal string AssemblyTitle {
            get {
                var attrs = _ea.GetCustomAttributes( typeof( AssemblyTitleAttribute ), false );
                if ( attrs.Length == 0 ) return Path.GetFileNameWithoutExtension( _ea.CodeBase );
                var tA = ( (AssemblyTitleAttribute) attrs[ 0 ] ).Title;
                return tA != "" ? tA : Path.GetFileNameWithoutExtension( _ea.CodeBase );
            }
        }
        internal string AssemblyVersion { get { return _ea.GetName().Version.ToString(); } }
        internal string AssemblyDescription { get { return this.GACA<AssemblyDescriptionAttribute>( a => a.Description ); } }
        internal string AssemblyProduct { get { return this.GACA<AssemblyProductAttribute>( a => a.Product ); } }
        internal string AssemblyCopyright { get { return this.GACA<AssemblyCopyrightAttribute>( a => a.Copyright ); } }
        internal string AssemblyCompany { get { return this.GACA<AssemblyCompanyAttribute>( a => a.Company ); } }
        #endregion
    }
}
