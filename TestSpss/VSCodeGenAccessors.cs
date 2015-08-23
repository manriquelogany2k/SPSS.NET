﻿using Xunit;

namespace Spss.Testing
{
    public class BaseAccessor
    {

        protected Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject m_privateObject;

        public BaseAccessor(object target, Microsoft.VisualStudio.TestTools.UnitTesting.PrivateType type)
        {
            m_privateObject = new Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject(target, type);
        }

        public virtual object Target
        {
            get
            {
                return m_privateObject.Target;
            }
        }

        public override string ToString()
        {
            return this.Target.ToString();
        }

        public override bool Equals(object obj)
        {
            if (typeof(BaseAccessor).IsInstanceOfType(obj))
            {
                obj = ((BaseAccessor)(obj)).Target;
            }
            return this.Target.Equals(obj);
        }

        public override int GetHashCode()
        {
            return this.Target.GetHashCode();
        }
    }


    public class Spss_SpssConvertAccessor : BaseAccessor
    {

        protected static Microsoft.VisualStudio.TestTools.UnitTesting.PrivateType m_privateType = new Microsoft.VisualStudio.TestTools.UnitTesting.PrivateType(typeof(global::Spss.SpssConvert));

        public Spss_SpssConvertAccessor(global::Spss.SpssConvert target) :
                base(target, m_privateType)
        {
        }

        public global::System.EventHandler notifyDoneCallback
        {
            get
            {
                global::System.EventHandler ret = ((global::System.EventHandler)(m_privateObject.GetField("notifyDoneCallback")));
                return ret;
            }
            set
            {
                m_privateObject.SetField("notifyDoneCallback", value);
            }
        }

        public global::System.EventHandler NotifyDoneCallback
        {
            get
            {
                global::System.EventHandler ret = ((global::System.EventHandler)(m_privateObject.GetProperty("NotifyDoneCallback")));
                return ret;
            }
        }

        public static global::Spss.SpssConvert CreatePrivate(global::System.EventHandler notifyDoneCallback)
        {
            object[] args = new object[] {
                notifyDoneCallback};
            Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject priv_obj = new Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject(typeof(global::Spss.SpssConvert), new System.Type[] {
                    typeof(global::System.EventHandler)}, args);
            return ((global::Spss.SpssConvert)(priv_obj.Target));
        }

        public void ToFileAsyncCB(global::System.IAsyncResult ar)
        {
            object[] args = new object[] {
                ar};
            m_privateObject.Invoke("ToFileAsyncCB", new System.Type[] {
                    typeof(global::System.IAsyncResult)}, args);
        }
    }
    public class Spss_SpssCasesCollectionAccessor : BaseAccessor
    {

        protected static Microsoft.VisualStudio.TestTools.UnitTesting.PrivateType m_privateType = new Microsoft.VisualStudio.TestTools.UnitTesting.PrivateType(typeof(global::Spss.SpssCasesCollection));

        public Spss_SpssCasesCollectionAccessor(global::Spss.SpssCasesCollection target) :
                base(target, m_privateType)
        {
        }

        public global::Spss.SpssDataDocument document
        {
            get
            {
                global::Spss.SpssDataDocument ret = ((global::Spss.SpssDataDocument)(m_privateObject.GetField("document")));
                return ret;
            }
            set
            {
                m_privateObject.SetField("document", value);
            }
        }

        public int FileHandle
        {
            get
            {
                int ret = ((int)(m_privateObject.GetProperty("FileHandle")));
                return ret;
            }
        }

        public int position
        {
            get
            {
                int ret = ((int)(m_privateObject.GetField("position")));
                return ret;
            }
            set
            {
                m_privateObject.SetField("position", value);
            }
        }

        public int Position
        {
            get
            {
                int ret = ((int)(m_privateObject.GetProperty("Position")));
                return ret;
            }
            set
            {
                m_privateObject.SetProperty("Position", value);
            }
        }

        public static global::Spss.SpssCasesCollection CreatePrivate(global::Spss.SpssDataDocument document)
        {
            object[] args = new object[] {
                document};
            Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject priv_obj = new Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject(typeof(global::Spss.SpssCasesCollection), new System.Type[] {
                    typeof(global::Spss.SpssDataDocument)}, args);
            return ((global::Spss.SpssCasesCollection)(priv_obj.Target));
        }
    }
    public class Spss_SpssVariablesCollectionAccessor : BaseAccessor
    {

        protected static Microsoft.VisualStudio.TestTools.UnitTesting.PrivateType m_privateType = new Microsoft.VisualStudio.TestTools.UnitTesting.PrivateType(typeof(global::Spss.SpssVariablesCollection));

        public Spss_SpssVariablesCollectionAccessor(global::Spss.SpssVariablesCollection target) :
                base(target, m_privateType)
        {
        }

        public global::System.Collections.ArrayList variables
        {
            get
            {
                global::System.Collections.ArrayList ret = ((global::System.Collections.ArrayList)(m_privateObject.GetField("variables")));
                return ret;
            }
            set
            {
                m_privateObject.SetField("variables", value);
            }
        }

        public global::Spss.SpssDataDocument document
        {
            get
            {
                global::Spss.SpssDataDocument ret = ((global::Spss.SpssDataDocument)(m_privateObject.GetField("document")));
                return ret;
            }
            set
            {
                m_privateObject.SetField("document", value);
            }
        }

        public int FileHandle
        {
            get
            {
                int ret = ((int)(m_privateObject.GetProperty("FileHandle")));
                return ret;
            }
        }

        public static global::Spss.SpssVariablesCollection CreatePrivate(global::Spss.SpssDataDocument document)
        {
            object[] args = new object[] {
                document};
            Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject priv_obj = new Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject(typeof(global::Spss.SpssVariablesCollection), new System.Type[] {
                    typeof(global::Spss.SpssDataDocument)}, args);
            return ((global::Spss.SpssVariablesCollection)(priv_obj.Target));
        }

        public void InitializeVariablesList()
        {
            object[] args = new object[0];
            m_privateObject.Invoke("InitializeVariablesList", new System.Type[0], args);
        }

        public void Commit()
        {
            object[] args = new object[0];
            m_privateObject.Invoke("Commit", new System.Type[0], args);
        }

        public void EnsureAuthoringDictionary()
        {
            object[] args = new object[0];
            m_privateObject.Invoke("EnsureAuthoringDictionary", new System.Type[0], args);
        }

        public string GenerateColumnName(string colName)
        {
            object[] args = new object[] {
                colName};
            string ret = ((string)(m_privateObject.Invoke("GenerateColumnName", new System.Type[] {
                    typeof(string)}, args)));
            return ret;
        }
    }
}
