using System;
using System.Data.SqlClient;

namespace Electrónicos.Jupiter
{

    public class JupiterConexion
    {
        private Conexion cn = new Conexion();

        private int Signal;
        private int Power;
        private string AppVersion;
        private string FPGAVersion;
        private string Estado;

        private string P1Responsable;
        private DateTime P1FechaIngreso;
        private DateTime P1HoraIngreso;
        private DateTime P1FechaFinal;
        private DateTime P1horaFinal;
        private int P1Signal;
        private int P1Power;
        private bool P1Resistencia38;
        private bool P1Voltaje33;
        private bool P1Voltaje66;
        private bool P1Voltaje10;
        private bool P1Voltaje60;
        private bool P1Voltaje24D2;
        private bool P1Voltaje24D3;
        private bool P1FormaOnda;
        private bool P1Comentario;

        private string R2Responsable;
        private DateTime R2FechaIngreso;
        private DateTime R2HoraIngreso;
        private DateTime R2FechaFinal;
        private DateTime R2horaFinal;
        private int R2Signal;
        private int R2Power;
        private bool R2Resistencia38;
        private bool R2Voltaje33;
        private bool R2Voltaje66;
        private bool R2Voltaje10;
        private bool R2Voltaje60;
        private bool R2Voltaje24D2;
        private bool R2Voltaje24D1;
        private bool R2FormaOnda;
        private bool R2Comentario;
        

        public JupiterConexion()
        {

        }

        public int Signal1 { get => Signal; set => Signal = value; }
        public int Power1 { get => Power; set => Power = value; }        
        public string AppVersion1 { get => AppVersion; set => AppVersion = value; }
        public string FPGAVersion1 { get => FPGAVersion; set => FPGAVersion = value; }
        public string Estado1 { get => Estado; set => Estado = value; }

        public string P1Responsable1 { get => P1Responsable; set => P1Responsable = value; }
        public DateTime P1FechaIngreso1 { get => P1FechaIngreso; set => P1FechaIngreso = value; }
        public DateTime P1HoraIngreso1 { get => P1HoraIngreso; set => P1HoraIngreso = value; }
        public DateTime P1FechaFinal1 { get => P1FechaFinal; set => P1FechaFinal = value; }
        public DateTime P1horaFinal1 { get => P1horaFinal; set => P1horaFinal = value; }
        public int P1Signal1 { get => P1Signal; set => P1Signal = value; }
        public int P1Power1 { get => P1Power; set => P1Power = value; }
        public bool P1Resistencia381 { get => P1Resistencia38; set => P1Resistencia38 = value; }
        public bool P1Voltaje331 { get => P1Voltaje33; set => P1Voltaje33 = value; }
        public bool P1Voltaje661 { get => P1Voltaje66; set => P1Voltaje66 = value; }
        public bool P1Voltaje101 { get => P1Voltaje10; set => P1Voltaje10 = value; }
        public bool P1Voltaje601 { get => P1Voltaje60; set => P1Voltaje60 = value; }
        public bool P1Voltaje24D21 { get => P1Voltaje24D2; set => P1Voltaje24D2 = value; }
        public bool P1Voltaje24D31 { get => P1Voltaje24D3; set => P1Voltaje24D3 = value; }
        public bool P1FormaOnda1 { get => P1FormaOnda; set => P1FormaOnda = value; }
        public bool P1Comentario1 { get => P1Comentario; set => P1Comentario = value; }
    

        public void guardadoInicial()
        {

            SqlCommand cmd = new SqlCommand("insert into Jupiter ([Signal],[Power],[P1 Responsable],[Estado],[App version],[FPGA version] ,[P1 Signal] , [P1 Power] , [P1 Fecha Ingreso],[P1 Hora Ingreso]) values (@Signal,@Power,@P1Responsable,@Estado,@App,@FPGA, @P1Signal,@P1Power ,@P1FechaIngreso, @P1HoraIngreso)", cn.conectarBD);
            cn.abrir();
            cmd.Parameters.AddWithValue("@Signal", 0);
            cmd.Parameters.AddWithValue("@Power", 0);
            cmd.Parameters.AddWithValue("@P1responsable", Common.ActiveUser.firstName + " " + Common.ActiveUser.lastName);
            cmd.Parameters.AddWithValue("@P1Signal", P1Signal);
            cmd.Parameters.AddWithValue("@P1Power", P1Power);
            cmd.Parameters.AddWithValue("@P1FechaIngreso", DateTime.Now.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@P1Horaingreso", DateTime.Now.ToString("HH:mm:ss"));
            cmd.Parameters.AddWithValue("@app", AppVersion);
            cmd.Parameters.AddWithValue("@FPGA", FPGAVersion);
            cmd.Parameters.AddWithValue("@Estado", Estado);

            cmd.ExecuteNonQuery();
            cn.cerrar();
        }

        public void AResistencia38()
        {
            SqlCommand cmd = new SqlCommand("update Jupiter set [P1 Resistencia 3.8] = @P1Resistencia38 where [P1 Signal] = @P1Signal and [P1 Power] = @P1Power", cn.conectarBD);
            cn.abrir();

            cmd.Parameters.AddWithValue("@P1Resitencia38", P1Resistencia38);
            cmd.Parameters.AddWithValue("@P1Signal", P1Signal);
            cmd.Parameters.AddWithValue("@P1Power", P1Power);
            cmd.ExecuteNonQuery();

            cn.cerrar();
        }

        public void AVoltaje33()
        {
            SqlCommand cmd = new SqlCommand("update Jupiter set [P1 Voltaje 3.3] = @P1Voltaje33 where [P1 Signal] = @P1Signal and [P1 Power] = @P1Power", cn.conectarBD);
            cn.abrir();

            cmd.Parameters.AddWithValue("@P1Voltaje33", P1Voltaje33);
            cmd.Parameters.AddWithValue("@P1Signal", P1Signal);
            cmd.Parameters.AddWithValue("@P1Power", P1Power);
            cmd.ExecuteNonQuery();

            cn.cerrar();
        }

        public void AVoltaje66()
        {
            SqlCommand cmd = new SqlCommand("update Jupiter set [P1 Voltaje 66] =  @P1Voltaje66 where [P1 Signal] = @P1Signal and [P1 Power] = @P1Power", cn.conectarBD);
            cn.abrir();

            cmd.Parameters.AddWithValue("@P1Voltaje66", P1Voltaje66);
            cmd.Parameters.AddWithValue("@P1Signal", P1Signal);
            cmd.Parameters.AddWithValue("@P1Power", P1Power);
            cmd.ExecuteNonQuery();

            cn.cerrar();
        }

        public void AVoltaje10()
        {
            SqlCommand cmd = new SqlCommand("update Jupiter set [P1 Voltaje -10] =  @P1Voltaje10 where [P1 Signal] = @P1Signal and [P1 Power] = @P1Power", cn.conectarBD);
            cn.abrir();

            cmd.Parameters.AddWithValue("@P1Voltaje10", P1Voltaje10);
            cmd.Parameters.AddWithValue("@P1Signal", P1Signal);
            cmd.Parameters.AddWithValue("@P1Power", P1Power);
            cmd.ExecuteNonQuery();

            cn.cerrar();
        }

        public void AVoltaje60()
        {
            SqlCommand cmd = new SqlCommand("update Jupiter set [P1 Voltaje 60] =  @P1Voltaje60 where [P1 Signal] = @P1Signal and [P1 Power] = @P1Power", cn.conectarBD);
            cn.abrir();

            cmd.Parameters.AddWithValue("@P1Voltaje60", P1Voltaje60);
            cmd.Parameters.AddWithValue("@P1Signal", P1Signal);
            cmd.Parameters.AddWithValue("@P1Power", P1Power);
            cmd.ExecuteNonQuery();

            cn.cerrar();
        }

        public void AVoltaje24D2()
        {
            SqlCommand cmd = new SqlCommand("update Jupiter set [P1 Voltaje 24 D2] =  @P1Voltaje24D2 where [P1 Signal] = @P1Signal and [P1 Power] = @P1Power", cn.conectarBD);
            cn.abrir();

            cmd.Parameters.AddWithValue("@P1Voltaje24D2", P1Voltaje24D2);
            cmd.Parameters.AddWithValue("@P1Signal", P1Signal);
            cmd.Parameters.AddWithValue("@P1Power", P1Power);
            cmd.ExecuteNonQuery();

            cn.cerrar();
        }

        public void AVoltaje24D3()
        {
            SqlCommand cmd = new SqlCommand("update Jupiter set [P1 Voltaje 24 D3] =  @P1Voltaje24D3 where [P1 Signal] = @P1Signal and [P1 Power] = @P1Power", cn.conectarBD);
            cn.abrir();

            cmd.Parameters.AddWithValue("@P1Voltaje24D3", P1Voltaje24D3);
            cmd.Parameters.AddWithValue("@P1Signal", P1Signal);
            cmd.Parameters.AddWithValue("@P1Power", P1Power);
            cmd.ExecuteNonQuery();

            cn.cerrar();
        }

        public void AFormaOnda()
        {
            SqlCommand cmd = new SqlCommand("update Jupiter set [P1 Forma de onda] =  @P1FormaOnda where [P1 Signal] = @P1Signal and [P1 Power] = @P1Power", cn.conectarBD);
            cn.abrir();

            cmd.Parameters.AddWithValue("@P1FOrmaOnda", P1FormaOnda);
            cmd.Parameters.AddWithValue("@P1Signal", P1Signal);
            cmd.Parameters.AddWithValue("@P1Power", P1Power);
            cmd.ExecuteNonQuery();

            cn.cerrar();
        }

        public void AComentario()
        {
            SqlCommand cmd = new SqlCommand("update Jupiter set [P1 Comentario] =  @P1Comentario where [P1 Signal] = @P1Signal and [P1 Power] = @P1Power", cn.conectarBD);
            cn.abrir();

            cmd.Parameters.AddWithValue("@P1Comentario", P1Comentario);
            cmd.Parameters.AddWithValue("@P1Signal", P1Signal);
            cmd.Parameters.AddWithValue("@P1Power", P1Power);
            cmd.ExecuteNonQuery();

            cn.cerrar();
        }

        public void AEstadoP1()
        {
            SqlCommand cmd = new SqlCommand("update Jupiter set [Estado] =  @Estado where [P1 Signal] = @P1Signal and [P1 Power] = @P1Power", cn.conectarBD);
            cn.abrir();

            cmd.Parameters.AddWithValue("@Estado", Estado1);
            cmd.Parameters.AddWithValue("@P1Signal", P1Signal);
            cmd.Parameters.AddWithValue("@P1Power", P1Power);
            cmd.ExecuteNonQuery();

            cn.cerrar();
        }

        //Verifica que el valor de P1Signal no se encuentra registado en la base de datos.
        public int VerificarSignal()
        {            
            cn.abrir();
            SqlCommand cmd = new SqlCommand("select [Signal] from Jupiter where [Signal] = @P1Signal", cn.conectarBD);
            cmd.Parameters.AddWithValue("@P1Signal", P1Signal);            
           
            int  valor = Convert.ToInt32(cmd.ExecuteScalar());            
            
            cn.cerrar();

            return valor;
        }

        //Verifica que el valor de P1Power no se encuentra registado en la base de datos.
        public int VerificarPower()
        {
            cn.abrir();
            SqlCommand cmd = new SqlCommand("select [Power] from Jupiter where [Power] = @P1Power", cn.conectarBD);
            cmd.Parameters.AddWithValue("@P1Power", P1Power);

            int valor = Convert.ToInt32(cmd.ExecuteScalar());
            cn.cerrar();

            return valor;
        }



    }
}
