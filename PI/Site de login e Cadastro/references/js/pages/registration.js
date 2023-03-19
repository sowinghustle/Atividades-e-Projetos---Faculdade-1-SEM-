function handleSubmit({ username, email, password }) {
  // make signin request
  axios
    .post(`${constants.API_BASE_URL}/auth/signup`, {
      username,
      password,
      email,
    })
    .then(function (response) {
      console.log(response.data);

      if (response.data.redirectTo) {
        window.location.href = response.data.redirectTo;
      }
    })
    .catch(function (error) {
      console.log(error);
    });
}
