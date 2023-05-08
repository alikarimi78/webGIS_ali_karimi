	<!DOCTYPE html>
<html lang="en" dir="ltr" xml:lang="en">
  <head>
    <title>Project 7 _ Ali karimi</title>
  </head>
  <body>
    <h1> absolute value </h1>
    <%

Dim param1
Dim param2

param1 = Request.QueryString("param1")
param2 = Request.QueryString("param2")

Dim param3

param3 = CInt(param1) + CInt(param2)

If param3 > 0 Then
    Response.Write("The absolute value of Sum is : " & param3)
Else
    Response.Write("The absolute value of Sum is : " & -1 * param3)
End If
%>

  </body>
</html>