//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.261
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace RosSharp
{
    
    
    /// <summary>
    /// The ConfigurationSection Configuration Section.
    /// </summary>
    public partial class ConfigurationSection : global::System.Configuration.ConfigurationSection
    {
        
        #region Singleton Instance
        /// <summary>
        /// The XML name of the ConfigurationSection Configuration Section.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        internal const string ConfigurationSectionSectionName = "rossharp";
        
        /// <summary>
        /// Gets the ConfigurationSection instance.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        public static global::RosSharp.ConfigurationSection Instance
        {
            get
            {
                return ((global::RosSharp.ConfigurationSection)(global::System.Configuration.ConfigurationManager.GetSection(global::RosSharp.ConfigurationSection.ConfigurationSectionSectionName)));
            }
        }
        #endregion
        
        #region Xmlns Property
        /// <summary>
        /// The XML name of the <see cref="Xmlns"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        internal const string XmlnsPropertyName = "xmlns";
        
        /// <summary>
        /// Gets the XML namespace of this Configuration Section.
        /// </summary>
        /// <remarks>
        /// This property makes sure that if the configuration file contains the XML namespace,
        /// the parser doesn't throw an exception because it encounters the unknown "xmlns" attribute.
        /// </remarks>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::RosSharp.ConfigurationSection.XmlnsPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public string Xmlns
        {
            get
            {
                return ((string)(base[global::RosSharp.ConfigurationSection.XmlnsPropertyName]));
            }
        }
        #endregion
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
        
        #region Node Property
        /// <summary>
        /// The XML name of the <see cref="Node"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        internal const string NodePropertyName = "node";
        
        /// <summary>
        /// Gets or sets the Node.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        [global::System.ComponentModel.DescriptionAttribute("The Node.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::RosSharp.ConfigurationSection.NodePropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public global::RosSharp.NodeElement Node
        {
            get
            {
                return ((global::RosSharp.NodeElement)(base[global::RosSharp.ConfigurationSection.NodePropertyName]));
            }
            set
            {
                base[global::RosSharp.ConfigurationSection.NodePropertyName] = value;
            }
        }
        #endregion
        
        #region Ros Property
        /// <summary>
        /// The XML name of the <see cref="Ros"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        internal const string RosPropertyName = "ros";
        
        /// <summary>
        /// Gets or sets the Ros.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        [global::System.ComponentModel.DescriptionAttribute("The Ros.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::RosSharp.ConfigurationSection.RosPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public global::RosSharp.RosElement Ros
        {
            get
            {
                return ((global::RosSharp.RosElement)(base[global::RosSharp.ConfigurationSection.RosPropertyName]));
            }
            set
            {
                base[global::RosSharp.ConfigurationSection.RosPropertyName] = value;
            }
        }
        #endregion
    }
}
namespace RosSharp
{
    
    
    /// <summary>
    /// The RosHostName Configuration Element.
    /// </summary>
    public partial class RosHostName : global::System.Configuration.ConfigurationElement
    {
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
        
        #region Value Property
        /// <summary>
        /// The XML name of the <see cref="Value"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        internal const string ValuePropertyName = "value";
        
        /// <summary>
        /// Gets or sets the Value.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        [global::System.ComponentModel.DescriptionAttribute("The Value.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::RosSharp.RosHostName.ValuePropertyName, IsRequired=true, IsKey=false, IsDefaultCollection=false)]
        public string Value
        {
            get
            {
                return ((string)(base[global::RosSharp.RosHostName.ValuePropertyName]));
            }
            set
            {
                base[global::RosSharp.RosHostName.ValuePropertyName] = value;
            }
        }
        #endregion
    }
}
namespace RosSharp
{
    
    
    /// <summary>
    /// The NodeElement Configuration Element.
    /// </summary>
    public partial class NodeElement : global::System.Configuration.ConfigurationElement
    {
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
        
        #region MasterUri Property
        /// <summary>
        /// The XML name of the <see cref="MasterUri"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        internal const string MasterUriPropertyName = "ROS_MASTER_URI";
        
        /// <summary>
        /// Gets or sets the MasterUri.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        [global::System.ComponentModel.DescriptionAttribute("The MasterUri.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::RosSharp.NodeElement.MasterUriPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public global::RosSharp.RosMasterUri MasterUri
        {
            get
            {
                return ((global::RosSharp.RosMasterUri)(base[global::RosSharp.NodeElement.MasterUriPropertyName]));
            }
            set
            {
                base[global::RosSharp.NodeElement.MasterUriPropertyName] = value;
            }
        }
        #endregion
    }
}
namespace RosSharp
{
    
    
    /// <summary>
    /// The RosElement Configuration Element.
    /// </summary>
    public partial class RosElement : global::System.Configuration.ConfigurationElement
    {
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
        
        #region HostName Property
        /// <summary>
        /// The XML name of the <see cref="HostName"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        internal const string HostNamePropertyName = "ROS_HOSTNAME";
        
        /// <summary>
        /// Gets or sets the HostName.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        [global::System.ComponentModel.DescriptionAttribute("The HostName.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::RosSharp.RosElement.HostNamePropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public global::RosSharp.RosHostName HostName
        {
            get
            {
                return ((global::RosSharp.RosHostName)(base[global::RosSharp.RosElement.HostNamePropertyName]));
            }
            set
            {
                base[global::RosSharp.RosElement.HostNamePropertyName] = value;
            }
        }
        #endregion
    }
}
namespace RosSharp
{
    
    
    /// <summary>
    /// The RosMasterUri Configuration Element.
    /// </summary>
    public partial class RosMasterUri : global::System.Configuration.ConfigurationElement
    {
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
        
        #region Value Property
        /// <summary>
        /// The XML name of the <see cref="Value"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        internal const string ValuePropertyName = "value";
        
        /// <summary>
        /// Gets or sets the Value.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        [global::System.ComponentModel.DescriptionAttribute("The Value.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::RosSharp.RosMasterUri.ValuePropertyName, IsRequired=true, IsKey=false, IsDefaultCollection=false)]
        public string Value
        {
            get
            {
                return ((string)(base[global::RosSharp.RosMasterUri.ValuePropertyName]));
            }
            set
            {
                base[global::RosSharp.RosMasterUri.ValuePropertyName] = value;
            }
        }
        #endregion
    }
}
