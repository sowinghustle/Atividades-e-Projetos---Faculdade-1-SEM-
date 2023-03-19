function handleSubmit({ password, usernameOrEmail }) {
  // axios é uma biblioteca para facilitar requisições à API's que substitui o fetch api (api de requisições do js)
  axios
    // faz uma requisição POST para a rota de login
    .post(
      `${constants.API_BASE_URL}/auth/signin`,
      // dados da requisição (BODY)
      {
        usernameOrEmail,
        password,
      }
    )
    // O método .post retorna uma PROMISE que deve ser acessada com o .then
    .then(function (
      response /* response é a resposta da API que vem com vários dados */
    ) {
      // os dados da requisição ficam em response.data
      console.log(response.data);

      // caso o servidor retorne (redirectTo) redirecionamos
      if (response.data.redirectTo) {
        window.location.href = response.data.redirectTo;
      }
    })
    // Caso a requisição dê erro, .catch é chamado em vez de .then
    .catch(function (error) {
      console.log(error);
    });
}
