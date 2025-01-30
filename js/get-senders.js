const prodUrl = "<REPLACE_WITH_PROD_URL>"
const token = "<YOUR_TOKEN>"

const getSenders = async () => {
  try {
    const params = new URLSearchParams({
      query: "searchTerm",
      status: "PENDING",
      allAccounts: "true",
    })

    const url = `${prodUrl}/v1/senders?${params}`

    const response = await fetch(url, {
      method: "GET",
      headers: {
        Authorization: `Bearer ${token}`,
        "Content-Type": "application/json",
      },
    })

    const responseData = await response.json()
    console.log(JSON.stringify(responseData))
  } catch (error) {
    console.log(error)
  }
}

getSenders()
