using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpGrammar
{

    // Class defintions that cannot be instantiated. No objects can be created of that class type.
   // It is designed to be extended by concrete classes that can be instantiated.
    public abstract class DataAccess
    {
        public string LoadConnString(string name)
        {
            string conn = "Connection String Sample " + name;
            return conn;
        }
        public abstract void LoadData(string sql);
        public abstract void SaveData(string sql);
    }

    public class MsSQL : DataAccess
    {
        public override void LoadData(string sql)
        {
            throw new NotImplementedException();
        }
        public override void SaveData(string sql)
        {
            throw new NotImplementedException();
        }
    }
    public class MySQL : DataAccess
    {
        public override void LoadData(string sql)
        {
            throw new NotImplementedException();
        }
        public override void SaveData(string sql)
        {
            throw new NotImplementedException();
        }
    }
    public class AbstractClass
    {
        public void Testing()
        {
        }
    }
}
