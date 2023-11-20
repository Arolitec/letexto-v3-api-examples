const url =
  '<REPLACE_WITH_PROD_URL>/v1/users/balance?token=<REPLACE_WITH_YOUR_MESSAGE_ID>'

const fetchData = async () => {
  try {
    const response = await fetch(url, {
      method: 'GET',
    })

    const data = await response.json()
    console.log(JSON.stringify(data))
  } catch (error) {
    console.log(error)
  }
}

fetchData()
