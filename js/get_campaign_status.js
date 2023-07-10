const url = "<REPLACE_WITH_PROD_URL>/v1/campaigns/1/status";
const token = "<YOUR_TOKEN>";

const fetchData = async () => {
  try {
    const response = await fetch(url, {
      method: "GET",
      headers: {
        Authorization: `Bearer ${token}`,
        "Content-Type": "application/json",
      },
    });

    const data = await response.json();
    console.log(JSON.stringify(data));
  } catch (error) {
    console.log(error);
  }
};

fetchData();

