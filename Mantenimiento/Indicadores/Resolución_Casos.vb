Imports System.Data.SqlClient

Public Class Resolución_Casos
    Private Sub Resolución_Casos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not formularios.Contains(Me) Then formularios.Add(Me) 'Agrega a la lista los formularios para luego cerrarlos

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        adatosDataSet.Clear()
        Dim adaptador As New SqlDataAdapter("
set language spanish;



with

indicadores4 as (
select Caso,[Fecha Inicial],[Fecha Final]
  from Indicadores1
)
,
IntervaloIndicador as (
select   month([Fecha Inicial]) Mes
       , case 
           when datediff(day, [Fecha Inicial], [Fecha Final]) <= 2 then '0-2'
           when datediff(day, [Fecha Inicial], [Fecha Final]) <= 4 then '3-4'
           when datediff(day, [Fecha Inicial], [Fecha Final]) <= 6 then '5-6'
           when datediff(day, [Fecha Inicial], [Fecha Final]) <= 10 then '7-10'
           else '10+'
         end Intervalo
  from Indicadores1
 where year([Fecha Inicial]) = 2021

-- DateName( month , DateAdd( month , Mes , 0 ) - 1 )

),


PruebaCT as (

	   select Intervalo, 
	   case 
           when  Mes=1 then '1'
		else 0		
         end Enero,
		   case 
           when  Mes=2 then '1'
		   else 0
         end Febrero,

		  case 
           when  Mes=3 then '1'
           else 0
         end Marzo,

		   case 
           when  Mes=4 then '1'
		else 0		
         end Abril,

		   case 
           when  Mes=5 then '1'
		   else 0
         end Mayo,

		  case 
           when  Mes=6 then '1'
           else 0
         end Junio,

		  case 
           when  Mes=7 then '1'
		else 0		
         end Julio,

		   case 
           when  Mes=8 then '1'
		   else 0
         end Agosto,

		  case 
           when  Mes=9 then '1'
           else 0
         end Septiembre,

		   case 
           when  Mes=10 then '1'
		else 0		
         end Octubre,

		   case 
           when  Mes=11 then '1'
		   else 0
         end Noviembre,

		  case 
           when  Mes=12 then '1'
           else 0
         end Diciembre
	
		 from IntervaloIndicador
	
		 )
		 	 --SELECT*FROM PruebaCT;
		
		
	

		 select Intervalo,case
		 when Intervalo=Intervalo then SUM(enero)
		end Enero,
		case
		when Intervalo=Intervalo then sum (Febrero)
		end Febrero,
		case
		when Intervalo=Intervalo then sum (Marzo)
		end Marzo,
		 case
		when Intervalo=Intervalo then sum (Abril)
		end Abril,case
		when Intervalo=Intervalo then sum (Mayo)
		end Mayo,
		case
		when Intervalo=Intervalo then sum (Junio)
		end Junio,
		case
		when Intervalo=Intervalo then sum (Julio)
		end Julio,
		 case
		when Intervalo=Intervalo then sum (Agosto)
		end Agosto,
		case
		when Intervalo=Intervalo then sum (Septiembre)
		end Septiembre,
		case
		when Intervalo=Intervalo then sum (Octubre)
		end Octubre,
		 case
		when Intervalo=Intervalo then sum (Noviembre)
		end Noviembre,
		case
		when Intervalo=Intervalo then sum (Diciembre)
		end Diciembre  from PruebaCT
		 group by Intervalo
	
		
		order by 
		case Intervalo
		when '0-2' then 1
		when '3-4' then 2
		when '5-6' then 3
		when '7-10' then 4
		when '10+' then 5
		end



", cn)
        adaptador.Fill(adatosDataSet, "Indicadores1")

        DataGridView1.DataSource = adatosDataSet.Tables("Indicadores1")
        desconectar()





    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim miView As DataView = New DataView(adatosDataSet.Tables("Indicadores1")) 'Enviamos a un dataview los datos




        Chart1.Series("Enero").Points.Clear()
		Chart1.Series("Febrero").Points.Clear()
		Chart1.Series("Marzo").Points.Clear()
		Chart1.Series("Abril").Points.Clear()
		Chart1.Series("Mayo").Points.Clear()
		Chart1.Series("Junio").Points.Clear()
		Chart1.Series("Julio").Points.Clear()
		Chart1.Series("Agosto").Points.Clear()
		Chart1.Series("Septiembre").Points.Clear()
		Chart1.Series("Octubre").Points.Clear()
		Chart1.Series("Noviembre").Points.Clear()
		Chart1.Series("Diciembre").Points.Clear()

		For x = 0 To miView.Count - 1
			Chart1.Series("Enero").Points.AddXY(miView(x)("Intervalo"), miView(x)("Enero"))
			Chart1.Series("Febrero").Points.AddXY(miView(x)("Intervalo"), miView(x)("Febrero"))
			Chart1.Series("Marzo").Points.AddXY(miView(x)("Intervalo"), miView(x)("Marzo"))
			Chart1.Series("Abril").Points.AddXY(miView(x)("Intervalo"), miView(x)("Abril"))
			Chart1.Series("Mayo").Points.AddXY(miView(x)("Intervalo"), miView(x)("Mayo"))
			Chart1.Series("Junio").Points.AddXY(miView(x)("Intervalo"), miView(x)("Junio"))
			Chart1.Series("Julio").Points.AddXY(miView(x)("Intervalo"), miView(x)("Julio"))
			Chart1.Series("Agosto").Points.AddXY(miView(x)("Intervalo"), miView(x)("Agosto"))
			Chart1.Series("Septiembre").Points.AddXY(miView(x)("Intervalo"), miView(x)("Septiembre"))
			Chart1.Series("Octubre").Points.AddXY(miView(x)("Intervalo"), miView(x)("Octubre"))
			Chart1.Series("Noviembre").Points.AddXY(miView(x)("Intervalo"), miView(x)("Noviembre"))
			Chart1.Series("Diciembre").Points.AddXY(miView(x)("Intervalo"), miView(x)("Diciembre"))



		Next


    End Sub


End Class