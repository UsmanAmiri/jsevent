
body {
	font-family: "Montserrat", sans-serif;
}

.row {
	display: flex;
}

.column {
	display: flex;
	flex-direction: column;
	flex-wrap: wrap;
}

section {
	width: 90%;
	margin: 20px auto;
	justify-content: space-between;
}

img {
	width: 100%;
}

#main_image_box {
	width: 40%;
}

#content {
	width: 55%;
}

#name {
	font-weight: 300;
    font-size: 44px;
    letter-spacing: -2px;
    margin-bottom: 0px;
}

h3, h4 {
	margin-top: 20px;
	margin-bottom: 0px;
    font-weight: 200;
    font-size: 20px;
    letter-spacing: 1px;
    color: #1b1919;
}

#price_value {
	color: #009688;
    font-weight: bold;
}

#description {
	margin-top: 20px;
    font-size: 16px;
    font-weight: 300;
    color: #86939e;
}

#preview_images img {
	margin: 5px;
    width: 15%;
    cursor: pointer;
    padding: 4px;
    border-radius: 6px;
}

.active {
	border: 2px solid #009688;
}

#add_to_cart_btn {
	width: fit-content;
	font-size: 16px;
    font-weight: bold;
    color: #ffffff;
    padding: 10px 20px;
    letter-spacing: 2px;
    background-color: #009688;
    border: none;
    border-radius: 4px;
    cursor: pointer;
    box-shadow: 0 2px 10px rgb(0 0 0 / 50%);
    margin-top: 20px;
}

@media only screen and (max-width: 600px)
{
	section {
		width: 95%;
		flex-wrap: wrap;
	}

	#main_image_box {
		width: 100%;
	}

	#content {
		width: 100%;
	}
}