using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reciclar
{
    class Donacion
    {
        public void AddDona(int idUser, DateTime fecha, int total, BD_RECICLARDataSet ds)
        {
            BD_RECICLARDataSetTableAdapters.QueriesTableAdapter add = new BD_RECICLARDataSetTableAdapters.QueriesTableAdapter();
            add.AddDonacion(idUser, fecha, total);
        }

        //public void ListaMaterial(BD_RECICLARDataSet.MaterialesDataTable ds)
        //{
        //    BD_RECICLARDataSetTableAdapters.MaterialesTableAdapter listar = new BD_RECICLARDataSetTableAdapters.MaterialesTableAdapter();
        //    listar.Fill(ds);
        //}

        public void Maximo(BD_RECICLARDataSet.BuscarIdDataTable ds)
        {
            BD_RECICLARDataSetTableAdapters.BuscarIdTableAdapter max = new BD_RECICLARDataSetTableAdapters.BuscarIdTableAdapter();
            max.Fill(ds);
        }

        public void BuscarDonacion(int idDevo, BD_RECICLARDataSet.Buscar_DetalleDonaDataTable ds)
        {
            BD_RECICLARDataSetTableAdapters.Buscar_DetalleDonaTableAdapter buscarDeta = new BD_RECICLARDataSetTableAdapters.Buscar_DetalleDonaTableAdapter();
            buscarDeta.Fill(ds, idDevo);
        }


        public void BuscarIdMaterial(string nom, BD_RECICLARDataSet.BuscarMaterialDataTable ds)
        {
            BD_RECICLARDataSetTableAdapters.BuscarMaterialTableAdapter buscarMate = new BD_RECICLARDataSetTableAdapters.BuscarMaterialTableAdapter();
            buscarMate.Fill(ds, nom);

        }
        //AÑADIR DETALLE DONACION
        public void DetalleDonacion(int idMate, int idDona, int total, BD_RECICLARDataSet ds)
        {
            BD_RECICLARDataSetTableAdapters.QueriesTableAdapter addDetalle = new BD_RECICLARDataSetTableAdapters.QueriesTableAdapter();
            addDetalle.AddDetaDona(idMate, idDona, total);
        }


        //ACTUALIZAR PUNTOS DEL USUARIO

        public void ActualizarPuntos(int user, int puntos, BD_RECICLARDataSet ds)
        {
            BD_RECICLARDataSetTableAdapters.QueriesTableAdapter actuapuntos = new BD_RECICLARDataSetTableAdapters.QueriesTableAdapter();
            actuapuntos.ActualizarPuntos(user, puntos);
        }


    }
}
