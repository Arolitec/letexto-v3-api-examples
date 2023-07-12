const prodUrl = "<REPLACE_WITH_PROD_URL>";
const token = "<YOUR_TOKEN>";

const url = encodeURI(`${prodUrl}/v1/messages/send?from=SMS INFO&to=2250000000000&content=Hello API!&token=${token}&dlrUrl=https://mydomain.com:4444/dlr&dlrMethod=GET&customData=customData&sendAt=2023-02-13T21:40:00.000Z`);

const fetchData = async () => {
  try {
    const response = await fetch(url, {
      method: "GET",
      headers: {},
    });

    const data = await response.json();
    console.log(JSON.stringify(data));
  } catch (error) {
    console.log(error);
  }
};

fetchData();
