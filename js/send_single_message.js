//replace with your own values
//AXIOS VERSION
//install axios first => npm install axios

var axios = require("axios");

var config = {
  method: "get",
  url: "http://localhost:3333/v1/messages/send?from=SMS INFO&to=225058543342&content=Hello API!&username=TR_c20c7c07429&password=1ad05b50&dlrUrl=https://mydomain.com:4444/dlr&dlrMethod=GET&customData=customData&sendAt=2023-02-13T21:40:00.000Z",
  headers: {},
};

axios(config)
  .then(function (response) {
    console.log(JSON.stringify(response.data));
  })
  .catch(function (error) {
    console.log(error);
  });
