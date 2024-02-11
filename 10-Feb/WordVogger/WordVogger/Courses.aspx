<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Courses.aspx.cs" Inherits="WordVogger.Courses" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Courses</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous"/>
    <link href="WordVoyagerStylesheet1.css" rel="stylesheet" />
    <style type="text/css">
        body{
            background-image:url("https://images.unsplash.com/photo-1512389055488-8d82cb26ba6c?q=80&w=1883&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D");
           background-repeat: no-repeat;
background-size: cover;       
            }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <nav class="navbar navbar-expand-lg navbar-light bg-light">
        <div class="container-fluid">
            <a  class="nav-link" href="WordVoyagerwebform1.aspx">Home</a>
            <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarNav">
                <ul class="navbar-nav">
                    <li class="nav-item">
                        <a class="nav-link" href="Courses.aspx">Courses</a>
                    </li>
                    <li class="nav-item">
                         <a class="nav-link" href="About%20Us.html">About Us</a>
                    </li>
                    </ul>
                    </div>
            </div>
            </nav>
        <div class= "card-group" > <!--"row row-cols-1 row-cols-md-3 g-4"--> 
            <div class="col">
            <div class="card" style="width: 18rem;">
  <img src="https://plus.unsplash.com/premium_photo-1677706393878-fd124fdae8f4?q=80&w=1935&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" class="card-img-top" alt="C language"/>
  <div class="card-body">
    <h5 class="card-title">C Language</h5>
    <p class="card-text">Some quick example text to build on C Language</p>
    <a href="#" class="btn btn-primary">Learn</a>
  </div>
</div>
</div>
            

        <div class="col">
            <div class="card" style="width: 18rem;">
  <img src="https://media.istockphoto.com/id/1431876307/photo/businessman-clicks-java-programming-language-application-concept-on-virtual-screen.jpg?s=1024x1024&w=is&k=20&c=ISPMEkopOc42ksBIfLD11XzPSK5oB5g5pxUPkTvxirQ=" class="card-img-top" alt="JAVA language"/>
  <div class="card-body">
    <h5 class="card-title">JAVA Language</h5>
    <p class="card-text">Some quick example text to build on JAVA Language</p>
    <a href="#" class="btn btn-primary">Learn</a>
  </div>
</div>
            </div>


           <div class="col">    
            <div class="card" style="width: 18rem;">
  <img src="https://images.unsplash.com/photo-1607706189992-eae578626c86?q=80&w=1770&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" class="card-img-top" alt="VISUAL STUDIO CODE"/>
  <div class="card-body">
    <h5 class="card-title">VISUAL STUDIO CODE</h5>
    <p class="card-text">Some quick example text to build on VISUAL STUDIO CODE Language</p>
    <a href="#" class="btn btn-primary">Learn</a>
  </div>
</div>
               </div>

        
           <div class="col">             
            <div class="card" style="width: 18rem;">
  <img src="https://media.istockphoto.com/id/1047259374/photo/programming-source-code-abstract-background.jpg?s=1024x1024&w=is&k=20&c=EUIT1eazlH-IFNzY7gKwk-Bj0RXiBd2R_k8s5Sq6FCU=" class="card-img-top" alt="JAVA SCRIPT CODE"/>
  <div class="card-body">
    <h5 class="card-title">JAVASCRIPT</h5>
    <p class="card-text">Some quick example text to build on JAVASCRIPT Language</p>
    <a href="#" class="btn btn-primary">Learn</a>
  </div>
</div>
               </div>
            </div>


       
 
    </form>
</body>
</html>
