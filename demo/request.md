---
title: Request Application
layout: page
permalink: /join/request/
---

<form class="usa-form">
    <fieldset>
      <legend>Request Application</legend>

 <label for="rank">Rank</label>
      <input id="rank" name="rank" type="text" required aria-required="true">

  <label for="last-name">Last name</label>
      <input id="last-name" name="last-name" type="text" required aria-required="true">
   <label for="first-name">First name</label>
      <input id="first-name" name="first-name" type="text" required aria-required="true">

   <label for="middle-name">Middle name</label>
      <input id="middle-name" name="middle-name" type="text" required aria-required="true">

<div class="usa-input-grid">
          <label for="service">Service</label>
          <select id="service" name="service">
            <option value="Army">Army</option>
            <option value="Navy">Navy</option>
            <option value="Air Force">Air Force</option>
            <option value="Marines">Marines</option>
            </select>
</div>

   <label for="occupation">MOS/AFSC/Rate</label>
      <input id="occupation" name="occupation" type="text" required aria-required="true">
     <label for="email">Email address</label>
    <input id="email" name="email" type="email" required aria-required="true" autocapitalize="off" autocorrect="off">
    <label for="telephone">Telephone</label>
    <input id="telephone" name="telephone" type="tel" required aria-required="true">
    <label for="comments">How did you hear about JCU?</label>
    <input id="comments" name="comments" type="text" required aria-required="true">
     <input type="submit" value="Submit">

   </fieldset>
  </form>