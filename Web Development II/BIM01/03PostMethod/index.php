<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>PHP</title>
    <style>
            </style>
</head>
<body>
    <section class="form-section">
        <form action="info.php" method="POST">
            Digite seu nome: 
            <input type="text" name="nome" class="inputform" required><br>
            Digite o assunto: 
            <input type="text" name="assunto" class="inputform" required>
            <select name="assunto">
                <option value="1">Dúvida</option>
                <option value="2">Reclamação</option>
            </select>
            <br>

            <input type="color" name="cor" required>
            <button>Enviar</button>
        </form>
    </section>
    
    
</body>
</html>
