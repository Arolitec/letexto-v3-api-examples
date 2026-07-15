const prodUrl = "<REPLACE_WITH_PROD_URL>"
const token = "<REPLACE_WITH_YOUR_API_KEY>"

const createCampaign = async () => {
  try {
    const data = JSON.stringify({
      label: "My WhatsApp Campaign",
      sender: "My Company",
      templateName: "order_confirmation",
      contacts: ["2250000000000", "2250000000001", "2250000000002"],
      parameters: ["John", "12345"],
      mediaUrl: "https://mydomain.com/image.jpg",
      notifyUrl: "https://mydomain.com:4444/dlr",
      skipDuplicates: true,
      sendAt: "2026-07-20T21:40:00.000Z",
    })

    const url = `${prodUrl}/v1/campaigns/whatsapp`

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

createCampaign()
