const prodUrl = "<REPLACE_WITH_PROD_URL>"
const token = "<REPLACE_WITH_YOUR_API_KEY>"

const sendWhatsAppMessage = async () => {
  try {
    const data = JSON.stringify({
      from: "My Company",
      to: "2250000000000",
      templateName: "order_confirmation",
      parameters: ["John", "12345"],
      mediaUrl: "https://mydomain.com/image.jpg",
      notifyUrl: "https://mydomain.com:4444/dlr",
    })

    const url = `${prodUrl}/v1/whatsapp/send`

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

sendWhatsAppMessage()
