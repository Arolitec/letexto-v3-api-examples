const prodUrl = "<REPLACE_WITH_PROD_URL>"
const token = "<REPLACE_WITH_YOUR_API_KEY>"

const sendData = async () => {
  try {
    const data = JSON.stringify({
      label: "My Campaign publipostage",
      from: "sender@mail.com",
      recipients: ["test@mail.com", "test@mail.com", "test@mail.com"],
      content: "Hello {{name}}, votre numéro est {{numero}}",
      subject: "subject",
    })

    const url = `${prodUrl}/v1/campaigns/emails`

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

sendData()
