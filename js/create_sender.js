const prodUrl = '<REPLACE_WITH_PROD_URL>'
const token = '<YOUR_TOKEN>'

const sendData = async () => {
  try {
    const data = JSON.stringify({
      name: 'My Sender',
    })

    const url = `${prodUrl}/v1/senders/create`

    const response = await fetch(url, {
      method: 'POST',
      headers: {
        Authorization: `Bearer ${token}`,
        'Content-Type': 'application/json',
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
