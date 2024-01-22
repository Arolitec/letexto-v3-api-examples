const url = "<REPLACE_WITH_PROD_URL>/v1/campaigns/sms/<YOUR_CAMPAIGN_ID>/status?token=<REPLACE_WITH_YOUR_API_KEY>"

const fetchData = async () => {
  try {
    const response = await fetch(url, {
      method: "GET",
      headers: {
        "Content-Type": "application/json",
      },
    })

    const data = await response.json()
    console.log(JSON.stringify(data))
  } catch (error) {
    console.log(error)
  }
}

fetchData()
