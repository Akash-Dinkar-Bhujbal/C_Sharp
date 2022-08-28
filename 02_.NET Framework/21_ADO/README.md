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
![2_Page_1](https://user-images.githubusercontent.com/44496666/187079459-3a524759-1bd3-40a7-9091-a6f4a89566b4.png)
![2_Page_2](https://user-images.githubusercontent.com/44496666/187079462-14c042c9-6abb-4c5e-8542-abb54bebba09.png)

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
![3_Page_1](https://user-images.githubusercontent.com/44496666/187079524-c9db7d2f-9d8c-4d8b-955c-cf4f4279a189.png)
![3_Page_2](https://user-images.githubusercontent.com/44496666/187079531-96e52a2d-a262-4cf6-a4a5-55073093dbd6.png)

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
![5](https://user-images.githubusercontent.com/44496666/187079549-79e1630a-051f-4793-b40f-bee14b093018.png)
### ExamForm1
1. Login
1. Exam

## ProcedureCall_ADO_GUI
- ProcedureCall.sln
- sql.txt
![6](https://user-images.githubusercontent.com/44496666/187079562-e3bad417-1040-46bf-821c-baf1958c9582.png)
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
![8_Page_1](https://user-images.githubusercontent.com/44496666/187079585-81a234c8-74c3-491a-af33-0276423611ab.png)
![8_Page_2](https://user-images.githubusercontent.com/44496666/187079590-fd40b914-7af9-478b-a19c-b99e3d96d096.png)
![8_Page_3](https://user-images.githubusercontent.com/44496666/187079594-4943576a-1882-4c8b-813e-b7720b3df605.png)


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
