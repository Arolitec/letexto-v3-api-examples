const url = '<REPLACE_WITH_PROD_URL>/v1/message/<YOUR MESSAGE ID>/status'
const token = '<YOUR_TOKEN>'

const fetchData = async () => {
  try {
    const response = await fetch(url, {
      method: 'GET',
      headers: {
        Authorization: `Bearer ${token}`,
      },
    })

    const data = await response.json()
    console.log(JSON.stringify(data))
  } catch (error) {
    console.log(error)
  }
}

fetchData()
