# BD2_Muebleria

| Integrantes               | Carnet     |
|---------------------------|------------|
| Daniel Araya Sambucci     | 2020207809 |
| Esteban Leiva Montenegro  | 2020426227 |
| Ana María Guevara Roselló | 2018102514 |

## Para ejecutar este proyecto:
Es necesario ejecutar el archivo createTables.sql 
luego de ejecutar el archivo anterior, es necesario abrir el archivo BD2_Muebleria/BD2_Muebleria/BD2_Muebleria.sln en Visual Studio, es necesario hacer cambios en
- App.config , cambiando la linea 
connectionString="Data Source= NOMBRE_DE_SU_SERVIDOR_SQLSERVER;Initial Catalog=MuebleriaMultimedia;Integrated Security=True"
- compra.cs
- agregarInventario.cs
- facturar.cs
- consultar.cs
cambiando las lineas que indiquen 
SqlConnection con = new SqlConnection("Data Source=NOMBRE_DE_SU_SERVIDOR_SQLSERVER;Initial Catalog=MuebleriaMultimedia;Integrated Security=True");
