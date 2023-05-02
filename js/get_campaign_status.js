//replace with your own values
//AXIOS VERSION
//install axios first => npm install axios

var axios = require("axios");

var config = {
  method: "get",
  url: "http://localhost:3333/v1/campaigns/1/status",
  headers: {
    Authorization: "Bearer dc408be00542eed70f4e7d1336d9a38735e5fa74",
    "Content-Type": "application/json",
  },
};

axios(config)
  .then(function (response) {
    console.log(JSON.stringify(response.data));
  })
  .catch(function (error) {
    console.log(error);
  });
