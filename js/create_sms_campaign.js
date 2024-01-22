const prodUrl = "<REPLACE_WITH_PROD_URL>"
const token = "<REPLACE_WITH_YOUR_API_KEY>"

const sendData = async () => {
  try {
    const data = JSON.stringify({
      label: "My Campaign publipostage",
      sender: "SMS INFO",
      contacts: [
        {
          age: "12",
          numero: "2250000000000",
          name: "Martial",
        },
        {
          age: "24",
          numero: "2250000000000",
          name: "Rita",
        },
        {
          age: "32",
          numero: "2250000000000",
          name: "John",
        },
      ],
      content: "Hello {{name}}, votre numéro est {{numero}}",
    })

    const url = `${prodUrl}/v1/campaigns/sms`

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
