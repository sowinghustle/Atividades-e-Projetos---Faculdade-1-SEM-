<?php
// $VinputNum1 = 0;
// $VinputNum2 = 0;
// // $VinputResult = 0;

// if (isset($_GET['inputNum1']) && isset($_GET['inputNum2']) && isset($_GET['inputResult'])) {
//     $VinputNum1 = $_GET['inputNum1'];
//     $VinputNum2 = $_GET['inputNum2'];
//     // $VinputResult = $_GET['inputResult'];
// }


?>

<?php
session_start();
?>



<!DOCTYPE html>
<html lang="pt-br">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <!-- Link HREF do arquivo css global -->
    <link rel="stylesheet" href="./assets/css/style.css" />
</head>

<body>
    <header>
        <h1>CalcTEC</h1>
    </header>
    <nav class="menu">
        <ul>
            <li><a href="https://www.fatecpp.edu.br/" target="_blank">Sobre</a></li>
            <li><a href="index.php">Calculadora</a></li>
            <li><a href="assets/php/temperatura.php">Temperatura</a></li>
            <li><a href="assets/php/conversor.php">Conversão</a></li>
        </ul>
    </nav>

    <div class="div-conteudo">
        <form method="POST" action="assets/php/logica/processamento.php">
            <label>Primeiro número:</label>
            <input value="<?php if (isset($_SESSION['sessaoNum1'])) {
                                echo $_SESSION['sessaoNum1'];
                            }  ?>" type="text" name="inputNum1" placeholder="Digite o número 1">
            <label>Segundo número:</label>
            <input value="<?php if (isset($_SESSION['sessaoNum2'])) {
                                echo $_SESSION['sessaoNum2'];
                            }  ?>" type="text" name="inputNum2" placeholder="Digite o número 2">
            <input value="<?php if (isset($_SESSION['resultNum'])) {
                                echo $_SESSION['resultNum'];
                            } ?>" type="text" name="inputResult" placeholder="" readonly>

            <select name="selectOperacoes">
                <option value="adicao">Adição</option>
                <option value="subtracao">Subtração</option>
                <option value="multiplicacao">Multiplicação</option>
                <option value="divisao">Divisão</option>
            </select>
            <input id="botao" type="submit" value="Calcular">
        </form>
        <img style="object-fit: contain;" src="assets/images/google-play.png">
    </div>

    <footer>
        <p>Desenvolvido por FATEC - Análise e Desenvolvimento de Sistemas - AMS</p>
        <p>"Feliz é aquele que programa"</p>
        <p>Copyright © 2023 - Todos os direitos reservados</p>
    </footer>
    <!-- Arquivo Scripts global -->
    <script src="assets/js/scripts.js" type="module"></script>
</body>




</html>