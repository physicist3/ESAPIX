using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Dynamic;
using X = ESAPIX.Facade.XContext;

namespace ESAPIX.Facade.API
{
    public class OptimizerObjectiveValue
    {
        internal dynamic _client;
        public OptimizerObjectiveValue() { _client = new ExpandoObject(); }
        public OptimizerObjectiveValue(dynamic client) { _client = client; }
        public bool IsLive { get { return !DefaultHelper.IsDefault(_client); } }
        public ESAPIX.Facade.API.Structure Structure
        {
            get
            {
                if (_client is ExpandoObject) { return _client.Structure; }
                var local = this;
                return X.Instance.CurrentContext.GetValue<ESAPIX.Facade.API.Structure>((sc) => { return new ESAPIX.Facade.API.Structure(local._client.Structure); });
            }
            set
            {
                if (_client is ExpandoObject) { _client.Structure = value; }
            }
        }
        public System.Double Value
        {
            get
            {
                if (_client is ExpandoObject) { return _client.Value; }
                var local = this;
                return X.Instance.CurrentContext.GetValue<System.Double>((sc) => { return local._client.Value; });
            }
            set
            {
                if (_client is ExpandoObject) { _client.Value = value; }
            }
        }
    }
}