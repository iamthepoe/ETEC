<?php
	$lado1 = $_POST['lado1'];
	$lado2 = $_POST['lado2'];
	$lado3 = $_POST['lado3'];
?>

<h1>
	<?php
		if($lado1<$lado2+$lado3 && $lado2<$lado1+$lado3 && $lado3<$lado2+$lado1){
			if($lado1==$lado2 && $lado2 == $lado3){
				echo 'O triângulo é equilátero';
			}else if($lado1==$lado2 || $lado1==$lado3 ||$lado3==$lado2){
				echo 'O triângulo é isóceles';
			}else{
				echo 'O triângulo é escaleno';
			}
		}else{
			echo 'Os valores informados não remetem a um triângulo.';
	}?>
</h1>