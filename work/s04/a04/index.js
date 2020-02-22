/**
 *Express Server
 */
"use strict";

const port    = process.env.DBWEBB_PORT || 1337;
const express = require("express");
const app     = express();

const routeLotto = require("./route/lotto.js");
const routeLottoJSON = require("./route/lottoJSON.js");
const middleware = require("./middleware/index.js");

const path = require("path");

app.use(middleware.logIncomingToConsole);


app.use(express.static(path.join(__dirname, "report")));
app.use("/lotto", routeLotto);
app.use("/lottoJSON", routeLottoJSON);
app.set("view engine", "ejs");
app.listen(port, logStartUpDetailsToConsole);
