<?php
require "funcoesCalculo.php";
session_start();

if (isset($_POST['inputNum1']) && isset($_POST['inputNum2'])) {
    $numero1 = $_POST['inputNum1'];
    $numero2 = $_POST['inputNum2'];
    $resultado = "";

    if ($_POST['selectOperacoes'] == "adicao") {
        $resultado = adicao($numero1, $numero2);
    } else if ($_POST['selectOperacoes'] == "subtracao") {
        $resultado = subtracao($numero1, $numero2);
    } else if ($_POST['selectOperacoes'] == "divisao") {
        $resultado = divisao($numero1, $numero2);
    } else if ($_POST['selectOperacoes'] == "multiplicacao") {
        $resultado = multiplicacao($numero1, $numero2);
    }
    $_SESSION['sessaoNum1'] = $numero1;
    $_SESSION['sessaoNum2'] = $numero2;
    $_SESSION['resultNum'] = $resultado;
    header("location:../../../index.php");
} else {

    header("location:../../../index.php");
}
