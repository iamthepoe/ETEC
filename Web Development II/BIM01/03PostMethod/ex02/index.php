<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title>PYTHAGORAS</title>
	<style>
		@import url('https://fonts.googleapis.com/css2?family=Poppins&display=swap');
		*{
			margin: 0;
			padding: 0;
			box-sizing: border-box;
		}
		body{
			background-color:#660033;
		}
		.header{
			display: flex;
			justify-content: center;
			align-items: center;
			width: 100%;
			height: 15vh;
			font-family: 'Poppins', sans-serif;
			color: white;
			background-color: rgba(26, 26, 26, 0.75);

		}

		.main{
			display: flex;
			width: 100%;
			height: 85vh;
			justify-content: center;
			align-items: center;
		}

		.main-form{
			display: flex;
			flex-flow: column;
			justify-content: center;
			align-items: center;
		}

		.main-form-label{
			color: white;
			font-family: 'Poppins', sans-serif;
		}

		.main-form-input{
			border: solid black 1px;
			border-radius: 50px;
			font-size: 20px;
			text-align: center;
			height: 30px;
			width: 300px;
		}

		.main-form-label,
		.main-form-input{
			margin: 5px;
		}

		#sendBtn{
			margin-top: 20px;
			font-family: 'Poppins', sans-serif;
			width: 200px;
			height: 40px;
			border-radius: 40px;
			border: 1px solid black;
		}

		#sendBtn:hover{
			cursor: pointer;
			background-color: black;
			color: white;
		}
	</style>
</head>
<body>
	<header class="header">
		<h1 class="header-title">P Y T H A G O R A S</h1>	
	</header>
	<main class="main">
		<form class="main-form" method="POST" action="triangle.php">
			<label class="main-form-label">Lado 1:</label>
			<input class="main-form-input" type="number" name="lado1" required>
			<label class="main-form-label">Lado 2:</label>
			<input class="main-form-input" type="number" name="lado2" required>
			<label class="main-form-label">Lado 3:</label>
			<input class="main-form-input" type="number" name="lado3" required>
			<button id="sendBtn">Enviar</button>
		</form>	
	</main>
	
</body>
</html>