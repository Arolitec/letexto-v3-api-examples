const url = "<REPLACE_WITH_PROD_URL>/v1/messages/<YOUR MESSAGE ID>/status?token=<REPLACE_WITH_YOUR_API_KEY>"

const fetchData = async () => {
  try {
    const response = await fetch(url, {
      method: "GET",
    })

    const data = await response.json()
    console.log(JSON.stringify(data))
  } catch (error) {
    console.log(error)
  }
}

fetchData()
