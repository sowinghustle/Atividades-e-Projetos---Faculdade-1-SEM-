const icon = document.querySelector('#icon-left')
icon.addEventListener("mouseover" , function() {icon.src='../references/svg/left-long-solid.svg'})
icon.addEventListener("mouseout", function() {
    icon.src='../references/svg/left-long-solid-black.svg'
  });


//   Script da requisição de dados pra LOGIN e REGISTRO
  sign.addEventListener('submit', (event) => {
    event.preventDefault();

    const form = event.currentTarget;

    const usernameOrEmail = form.elements.usernameOrEmail.value;
    const username = form.elements.username.value;
    const email = form.elements.email.value;
    const password = form.elements.password.value;

    // TODO: validate fields


    return handleSubmit({ isLoginForm, username, email, password, usernameOrEmail });
});
// SCRIPT DO GOOGLEAUTH
googleAuthBtn.addEventListener('click', () => {
    location.href = `${constants.API_BASE_URL}/auth/google`;
});
