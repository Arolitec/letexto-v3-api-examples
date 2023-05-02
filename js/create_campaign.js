//replace with your own values
//AXIOS VERSION
//install axios first => npm install axios

var axios = require("axios");
var data = JSON.stringify({
  label: "My Campaign publipostage",
  sender: "SMS INFO",
  contacts: [
    {
      age: "12",
      numero: "22507489171",
      name: "Martial",
    },
    {
      age: "24",
      numero: "22507865918",
      name: "Rita",
    },
    {
      age: "32",
      numero: "22506275212",
      name: "Arolitec",
    },
  ],
  content: "Hello {{name}}, votre numéro est {{numero}}",
});

var config = {
  method: "post",
  url: "http://localhost:3333/v1/campaigns",
  headers: {
    Authorization: "Bearer dc408be00542eed70f4e7d1336d9a38735e5fa74",
    "Content-Type": "application/json",
  },
  data: data,
};

axios(config)
  .then(function (response) {
    console.log(JSON.stringify(response.data));
  })
  .catch(function (error) {
    console.log(error);
  });
