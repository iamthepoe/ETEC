<?php
	echo $_COOKIE['username'];
?>
<!DOCTYPE html>
<html>
<head>
	<title>Pergunta</title>
</head>
<body>
	<form method="POST">
		<br>
		Pergunta:<br>
		Com quantos paus se faz uma canoa?s
		<select name="p1">
			<option value="666">666 paus</option>
			<option value="69">69 paus</option>
		</select>
	</form>
	
	<?php 
		$resp = $_POST['p1'];

		if($resp ){
			echo $resp;
		}
	?>
</body>
</html>