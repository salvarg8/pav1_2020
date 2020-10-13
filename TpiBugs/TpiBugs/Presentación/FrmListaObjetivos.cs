using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpiBugs.Datos.Dao.Implementacion;
using TpiBugs.Negocio.Entidades;
using TpiBugs.Negocio.Servicios;


namespace TpiBugs.Presentación
{
    public partial class FrmListaObjetivos : Form
    {
        public FrmListaObjetivos()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //nose como recuperar la lista de la dgv de arriba
            List<Objetivos> objectObjetivoxCursoList = new List<Objetivos>();
            //contar cuantos objetivos tengo para dividir 100 en esa cantidad y guardarlo en una variable

            //borrar las entradas de la tabla objetivosporcurso para el curso seleccionado 
            //para despues agregar los nuevos objetivos con el puntaje calculado

            //n = cantidadderegistrosenlatabla
            //if count.List <> 0 
            //    puntoscalculados = 100 / n
            //else
            //    mesagebox No hay objetivos seleccionados
            //ACA ARRANCARIA LA TRANSACCION


            int id_curso = 

            foreach (DataGridViewRow dgvRow in dgvObjetivos.Rows) 
            {   
                var detail = new ObjetivosCursos()
                //creo que ObjetivosxCurso deberia ser un objeto de la tabla ObjetivoxCategoria
                {
                    int id_curso = oCursoSelected.Id_curso
                    int Id_Objetivos = Convert.ToInt32(dgvObjetivosCursos.CurrentRow.Cells["Id_Objetivos"].Value);
                    //Id_Objetivos = Convert.ToInt32(dgvRow.Cell["Id_Objetivos"].Value),
                    puntos = puntoscalculados
                    borrado = Convert.ToInt32(dgvRow.Cells["Borrado"].Value)

                };

                ObjetivosCursos detalles = new ObjetivosCursos();
                insertar detalles.actualizarTablaObjetivosCursoDAO;
            }

        }
    }
}
