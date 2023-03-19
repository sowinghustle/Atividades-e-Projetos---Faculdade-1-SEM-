const iconElement = document.querySelector(".icon");

iconElement.addEventListener("mouseover", function quandoMouseSobre() {
  iconElement.src = "../references/svg/left-long-solid.svg";
});

iconElement.addEventListener("mouseout", function quandoMouseSairSobre() {
  iconElement.src = "../references/svg/left-long-solid-black.svg";
});

const constants = {
  API_BASE_URL: "",
};

document
  .querySelector("form") // document.querySelector serve para pegar elementos da página (neste caso o primeiro form que ele encontrar)
  .addEventListener(
    "submit" /* Tipo de evento (exemplos 'click', 'mouseover', 'input'), pode variar dependendo do elemento */,
    function quandoSubmeterForm(
      event /* O método addEventListener() em JavaScript é usado para anexar um manipulador de eventos a um elemento sem sobreescrever manipuladores de eventos existentes*/
      // O método addEventListener() em JavaScript é usado para anexar um manipulador de eventos a um elemento sem sobreescrever manipuladores de eventos existentes
    ) {
      event.preventDefault();

      const form = event.currentTarget;

      // pega elementos pelo name (mas o elemento deve estar dentro do form)
      const usernameOrEmail = form.elements.usernameOrEmail.value;
      const username = form.elements.username.value;
      const email = form.elements.email.value;
      const password = form.elements.password.value;

      // cada página, login e registro, tem o seu próprio handleSubmit
      return handleSubmit({
        username,
        email,
        password,
        usernameOrEmail,
      });
    }
  );

// googleAuthBtn.addEventListener('click', () => {
//     location.href = `${constants.API_BASE_URL}/auth/google`;
// });
