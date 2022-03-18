<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Luca</title>
</head>
<body>
    <form method="POST">
        Digite seu nome:
        <input type="text" name="nome"><br>
        Digite seu email:
        <input type="email" name="email"><br>
        Assunto:
        <select name="assunto">
            <option value="duvida">Duvida</option>
            <option value="reclamação">RECLAMAÇÃO</option>
            <option value="elogio">ELOGIO</option>
        </select><br>
        mensagem:<br>
        <textarea name="msg"></textarea>
        <button type="submit">ENVIAR</button>
        <?php
            
        ?>
    </form>
    <?php
        if($_POST){
            $nome = $_POST['nome'];
            $email = $_POST['email'];
            $assunto = $_POST['assunto'];
            $msg = $_POST['msg'];
            $texto = "\r\nNome: ".$nome."\r\nEmail: ".$email."\r\nAssunto: ".$assunto."\r\nMensagem: ".$msg."\r\n--------------------------";
            $nome = 'registro.txt';
            $arquivo = fopen($nome, 'a+');
            fwrite($arquivo, $texto);
            fclose($arquivo);
        }
        
    ?>
</body>
</html>