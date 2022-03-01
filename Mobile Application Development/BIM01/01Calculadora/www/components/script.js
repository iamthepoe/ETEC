// This is a JavaScript file


function Soma(){
    let result = document.getElementById("resultado");
    let valor1 = Number(document.getElementById("valor1").value);
    let valor2 = Number(document.getElementById("valor2").value);
    let soma = valor1 + valor2;
    result.value = soma;
}