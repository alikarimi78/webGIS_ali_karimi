<!DOCTYPE html>
<html lang="en" dir="ltr" xml:lang="en">
  <head>
    <title>Project 7 _ Ali karimi</title>
  </head>
  <body>
    <h1> absolute value </h1>
    <%

Dim number

number = Request.QueryString("number")

If CInt(number) > 0 Then
    Response.Write("The absolute value of number is : " & number)
Else
    Response.Write("The absolute value of number is : " & -1 * number)
End If
%>

  </body>
</html>