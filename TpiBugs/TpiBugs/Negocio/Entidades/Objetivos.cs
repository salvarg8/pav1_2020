﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpiBugs.Datos.Dao.Implementacion;
using TpiBugs.Negocio.Servicios;

namespace TpiBugs.Negocio.Entidades
{
    public class Objetivos
    {

        public int ID_objetivos { get; set; }
        public string Nombre_corto { get; set; }
        public string Nombre_largo { get; set; }
        public bool Borrado { get; set; }

       private ObjetivosDao oObjetivosDao;
        public Objetivos()
                {
                    oObjetivosDao = new ObjetivosDao();
                }
        public List<Objetivos> listObjetivos { get; set; }


        //public Objetivos()
        //{
        //    listObjetivos = new List<Objetivos>();
        //}


        public Objetivos(int id, string nomCorto, string nomLargo)
        {
            this.ID_objetivos = id;
            this.Nombre_corto = nomCorto;
            this.Nombre_largo = nomLargo;
        }

        //internal bool actualizarObjetivo(Objetivos oObjetivoSeleccionado)
        //{
        //    return oObjetivosDao.Actualizar(oObjetivoSeleccionado);
        //}

        public override string ToString()
        {
            return Nombre_corto;
        }
    }
}