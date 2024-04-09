using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.XtraGrid.Views.Grid;
namespace GestorFactura.bdventa
{

    public partial class Detalle
    {
        public Detalle(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        public static implicit operator GridView(Detalle v)
        {
            throw new NotImplementedException();
        }
    }

}
