using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Dynamic;
using X = ESAPIX.Facade.XContext;

namespace ESAPIX.Facade.API
{
    public class Dose : ESAPIX.Facade.API.ApiDataObject
    {
        public Dose() { _client = new ExpandoObject(); }
        public Dose(dynamic client) { _client = client; }
        public bool IsLive { get { return !DefaultHelper.IsDefault(_client); } }
        public ESAPIX.Facade.Types.DoseValue DoseMax3D
        {
            get
            {
                if (_client is ExpandoObject) { return _client.DoseMax3D; }
                var local = this;
                return X.Instance.CurrentContext.GetValue<ESAPIX.Facade.Types.DoseValue>((sc) => { return new ESAPIX.Facade.Types.DoseValue(local._client.DoseMax3D); });
            }
            set
            {
                if (_client is ExpandoObject) { _client.DoseMax3D = value; }
            }
        }
        public ESAPIX.Facade.Types.VVector DoseMax3DLocation
        {
            get
            {
                if (_client is ExpandoObject) { return _client.DoseMax3DLocation; }
                var local = this;
                return X.Instance.CurrentContext.GetValue<ESAPIX.Facade.Types.VVector>((sc) => { return new ESAPIX.Facade.Types.VVector(local._client.DoseMax3DLocation); });
            }
            set
            {
                if (_client is ExpandoObject) { _client.DoseMax3DLocation = value; }
            }
        }
        public IEnumerable<ESAPIX.Facade.API.Isodose> Isodoses
        {
            get
            {
                IEnumerator enumerator = null;
                X.Instance.CurrentContext.Thread.Invoke(() =>
                {
                    var asEnum = (IEnumerable)_client.Isodoses;
                    enumerator = asEnum.GetEnumerator();
                });
                while (X.Instance.CurrentContext.GetValue<bool>(sc => enumerator.MoveNext()))
                {
                    var facade = new ESAPIX.Facade.API.Isodose();
                    X.Instance.CurrentContext.Thread.Invoke(() =>
                    {
                        var vms = enumerator.Current;
                        if (vms != null)
                        {
                            facade._client = vms;
                        }
                    });
                    if (facade._client != null)
                    { yield return facade; }
                }
            }
        }
        public ESAPIX.Facade.Types.VVector Origin
        {
            get
            {
                if (_client is ExpandoObject) { return _client.Origin; }
                var local = this;
                return X.Instance.CurrentContext.GetValue<ESAPIX.Facade.Types.VVector>((sc) => { return new ESAPIX.Facade.Types.VVector(local._client.Origin); });
            }
            set
            {
                if (_client is ExpandoObject) { _client.Origin = value; }
            }
        }
        public ESAPIX.Facade.API.Series Series
        {
            get
            {
                if (_client is ExpandoObject) { return _client.Series; }
                var local = this;
                return X.Instance.CurrentContext.GetValue<ESAPIX.Facade.API.Series>((sc) => { return new ESAPIX.Facade.API.Series(local._client.Series); });
            }
            set
            {
                if (_client is ExpandoObject) { _client.Series = value; }
            }
        }
        public System.String SeriesUID
        {
            get
            {
                if (_client is ExpandoObject) { return _client.SeriesUID; }
                var local = this;
                return X.Instance.CurrentContext.GetValue<System.String>((sc) => { return local._client.SeriesUID; });
            }
            set
            {
                if (_client is ExpandoObject) { _client.SeriesUID = value; }
            }
        }
        public System.String UID
        {
            get
            {
                if (_client is ExpandoObject) { return _client.UID; }
                var local = this;
                return X.Instance.CurrentContext.GetValue<System.String>((sc) => { return local._client.UID; });
            }
            set
            {
                if (_client is ExpandoObject) { _client.UID = value; }
            }
        }
        public ESAPIX.Facade.Types.VVector XDirection
        {
            get
            {
                if (_client is ExpandoObject) { return _client.XDirection; }
                var local = this;
                return X.Instance.CurrentContext.GetValue<ESAPIX.Facade.Types.VVector>((sc) => { return new ESAPIX.Facade.Types.VVector(local._client.XDirection); });
            }
            set
            {
                if (_client is ExpandoObject) { _client.XDirection = value; }
            }
        }
        public System.Double XRes
        {
            get
            {
                if (_client is ExpandoObject) { return _client.XRes; }
                var local = this;
                return X.Instance.CurrentContext.GetValue<System.Double>((sc) => { return local._client.XRes; });
            }
            set
            {
                if (_client is ExpandoObject) { _client.XRes = value; }
            }
        }
        public System.Int32 XSize
        {
            get
            {
                if (_client is ExpandoObject) { return _client.XSize; }
                var local = this;
                return X.Instance.CurrentContext.GetValue<System.Int32>((sc) => { return local._client.XSize; });
            }
            set
            {
                if (_client is ExpandoObject) { _client.XSize = value; }
            }
        }
        public ESAPIX.Facade.Types.VVector YDirection
        {
            get
            {
                if (_client is ExpandoObject) { return _client.YDirection; }
                var local = this;
                return X.Instance.CurrentContext.GetValue<ESAPIX.Facade.Types.VVector>((sc) => { return new ESAPIX.Facade.Types.VVector(local._client.YDirection); });
            }
            set
            {
                if (_client is ExpandoObject) { _client.YDirection = value; }
            }
        }
        public System.Double YRes
        {
            get
            {
                if (_client is ExpandoObject) { return _client.YRes; }
                var local = this;
                return X.Instance.CurrentContext.GetValue<System.Double>((sc) => { return local._client.YRes; });
            }
            set
            {
                if (_client is ExpandoObject) { _client.YRes = value; }
            }
        }
        public System.Int32 YSize
        {
            get
            {
                if (_client is ExpandoObject) { return _client.YSize; }
                var local = this;
                return X.Instance.CurrentContext.GetValue<System.Int32>((sc) => { return local._client.YSize; });
            }
            set
            {
                if (_client is ExpandoObject) { _client.YSize = value; }
            }
        }
        public ESAPIX.Facade.Types.VVector ZDirection
        {
            get
            {
                if (_client is ExpandoObject) { return _client.ZDirection; }
                var local = this;
                return X.Instance.CurrentContext.GetValue<ESAPIX.Facade.Types.VVector>((sc) => { return new ESAPIX.Facade.Types.VVector(local._client.ZDirection); });
            }
            set
            {
                if (_client is ExpandoObject) { _client.ZDirection = value; }
            }
        }
        public System.Double ZRes
        {
            get
            {
                if (_client is ExpandoObject) { return _client.ZRes; }
                var local = this;
                return X.Instance.CurrentContext.GetValue<System.Double>((sc) => { return local._client.ZRes; });
            }
            set
            {
                if (_client is ExpandoObject) { _client.ZRes = value; }
            }
        }
        public System.Int32 ZSize
        {
            get
            {
                if (_client is ExpandoObject) { return _client.ZSize; }
                var local = this;
                return X.Instance.CurrentContext.GetValue<System.Int32>((sc) => { return local._client.ZSize; });
            }
            set
            {
                if (_client is ExpandoObject) { _client.ZSize = value; }
            }
        }
        public void WriteXml(System.Xml.XmlWriter writer)
        {
            var local = this;
            X.Instance.CurrentContext.Thread.Invoke(() =>
            {
                local._client.WriteXml(writer);
            });

        }
        public ESAPIX.Facade.Types.DoseProfile GetDoseProfile(ESAPIX.Facade.Types.VVector start, ESAPIX.Facade.Types.VVector stop, System.Double[] preallocatedBuffer)
        {
            var local = this;
            var retVal = X.Instance.CurrentContext.GetValue((sc) => { return new ESAPIX.Facade.Types.DoseProfile(local._client.GetDoseProfile(start._client, stop._client, preallocatedBuffer)); });
            return retVal;

        }
        public ESAPIX.Facade.Types.DoseValue GetDoseToPoint(ESAPIX.Facade.Types.VVector at)
        {
            var local = this;
            var retVal = X.Instance.CurrentContext.GetValue((sc) => { return new ESAPIX.Facade.Types.DoseValue(local._client.GetDoseToPoint(at._client)); });
            return retVal;

        }
        public void GetVoxels(System.Int32 planeIndex, System.Int32[,] preallocatedBuffer)
        {
            var local = this;
            X.Instance.CurrentContext.Thread.Invoke(() =>
            {
                local._client.GetVoxels(planeIndex, preallocatedBuffer);
            });

        }
        public void SetVoxels(System.Int32 planeIndex, System.Int32[,] values)
        {
            var local = this;
            X.Instance.CurrentContext.Thread.Invoke(() =>
            {
                local._client.SetVoxels(planeIndex, values);
            });

        }
        public ESAPIX.Facade.Types.DoseValue VoxelToDoseValue(System.Int32 voxelValue)
        {
            var local = this;
            var retVal = X.Instance.CurrentContext.GetValue((sc) => { return new ESAPIX.Facade.Types.DoseValue(local._client.VoxelToDoseValue(voxelValue)); });
            return retVal;

        }
    }
}