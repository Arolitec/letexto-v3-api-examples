const prodUrl = "<REPLACE_WITH_PROD_URL>"
const token = "<REPLACE_WITH_YOUR_API_KEY>"

const sendMessage = async () => {
  try {
    const data = JSON.stringify({
      from: "SMS INFO",
      to: "2250000000000",
      content: "Hello API!",
      dlrUrl: "https://mydomain.com:4444/dlr",
      dlrMethod: "GET",
      customData: "customData",
      sendAt: "2023-02-13T21:40:00.000Z",
    })

    const url = `${prodUrl}/v1/messages/send`

    const response = await fetch(url, {
      method: "POST",
      headers: {
        Authorization: `Bearer ${token}`,
        "Content-Type": "application/json",
      },
      body: data,
    })

    const responseData = await response.json()
    console.log(JSON.stringify(responseData))
  } catch (error) {
    console.log(error)
  }
}

sendMessage()
