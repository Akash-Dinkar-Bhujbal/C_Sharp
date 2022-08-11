# C_Sharp
Let's learn deeply C# language and their frameworks together...
## ActiveX Data Objects
ADO is a Microsoft Active-X component. ADO is automatically installed with Microsoft IIS. ADO is a programming interface to access data in a database.
<!--// ADO1.sql-->

## ADO_Sample
- ADO1.sln
- sql.txt
<!--Images-->

<dependency>
	<groupId>com.ramotion.cardslider</groupId>
	<artifactId>card-slider</artifactId>
	<version>0.3.1</version>
</dependency>

</br></br>

## WindowsForm1_ADO_GUI
- WidowsForm1.sln
- sql.txt
<!--Images-->
### WindowsForm1
1. Factorial of Number
2. Find Employee
3. Insert Employee
4. Update Employee
5. Delete Employee
6. Exam: 5 Quetion in Form using GroupBox
7. Fetch QNA

## WinFormsApp2_ADO_GUI
- WinFormsApp2.sln
- sql.txt
<!--Images-->
### WinFormsApp2
1. CheckBox, CheckBoxList, listBox
2. CheckBox Form
3. Choose Even/Odd using listBox
4. Generate Bill of items

## DISCONNECTION
// This is Story : where we don't need Connection Open & Close
<!--Images-->

## ExamForm_ADO_GUI
- ExamForm1.sln
- sql.txt
<!--Images-->
### ExamForm1
1. Login
1. Exam

## ProcedureCall_ADO_GUI
- ProcedureCall.sln
- sql.txt
<!--Images-->
### ProcedureCall
1. Display Employee Details

## ProcedureCallwithOutput_ADO_Console
- ProcedureCallwithOutput_ADO.sln
- sql.txt
<!--Images-->
### ProcedureCallwithOutput_ADO
1. abCreateStudent

## ProcedureCallwithOutput_ADO_GUI
- ProcedureCallwithOutput_ADO_GUI.sln
- sql.txt
<!--Images-->

### ProcedureCallwithOutput_ADO_GUI
1. Main Menu
2. Insert
3. Update
4. Delete
5. Display


<!--### ExamForm1
![ADO1 sql - Made with Clipchamp](https://user-images.githubusercontent.com/44496666/182043458-31e122c0-ee55-407e-8da9-db4b5f46c7da.gif)
Tables
![Exam Form - Made with Clipchamp](https://user-images.githubusercontent.com/44496666/182043462-b7c2393b-8eb4-49ba-a80f-64ec03333423.gif)
Running Application-->

## Notes:
```sql
SqlConnection conn = new SqlConnection("SERVER=NSL-LTRG007\\SQLEXPRESS2019;INITIAL CATALOG=TEST1;INTEGRATED SECURITY=TRUE");
//ADO:
        conn.Open();
        SqlCommand cmd = new SqlCommand(query, conn);//
        SqlDataReader reader = cmd.ExecuteReader();
         while (reader.Read())
        {
            Console.Write(reader[0].ToString() + " ");//col1:id
            Console.Write(reader[1].ToString() + " ");//col2:name
            Console.WriteLine(reader[2].ToString());//col3:sal
        }
        conn.Close();

// Disconnection:
        SqlDataAdapter da = new SqlDataAdapter(query, conn);
        DataSet ds = new DataSet();
        da.Fill(ds,TableName);
        foreach(DataRow dr in ds.Tables[TableName].Rows)
        {
            Console.WriteLine(dr[0].ToString()+" "+ dr[1].ToString()+" "+ dr[2].ToString());
        }
```
### Dependencies:
    System.Data.SqlClient