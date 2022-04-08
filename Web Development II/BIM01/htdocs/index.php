<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta language="pt-br">
	<title>Mandioquinha</title>
</head>
<body>
	<form method="post">
		Digite seu nome:
		<input type="nome" name="nome" id="nome">
		<button>Enviar</button>
	</form>
	<?php 
		if($_POST){
			$nome = $_POST['nome'];
			setcookie('username',$nome, time()+30);	
			header('location: pergunta.php');
		}
	?>

</body>
</html>