<script setup lang="ts">
import { RouterView } from "vue-router";
</script>
<script lang="ts">
function openNav() {
    window.document.getElementById("mySidenav")!.style.width = "250px";

  }
  function closeNav() {
    window.document.getElementById("mySidenav")!.style.width = "0";

  }
</script>
<template>
  <div class="app">
    <span style="font-size:30px;cursor:pointer" @click="openNav()">&#9776</span>
    <router-view />
  </div>
  <div id="mySidenav" class="sidenav">
    <a href="javascript:void(0)" class="closebtn" @click="closeNav()">&times;</a>
    <router-link to="/" @click="closeNav()">Home</router-link>
    <router-link to="/menu" @click="closeNav()">Menu</router-link>
    <router-link to="#" @click="closeNav()">About</router-link>
    <router-link to="#" @click="closeNav()">Contact</router-link>
    <router-link to="#" @click="closeNav()">Login</router-link>
  </div>
</template>
<style>
@import "@/assets/main.css";
html,
body {
  margin: 0;
  padding: 0;
}

#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}

.app {
  background-image: linear-gradient(135deg, var(--governor-bay-300) 0%, var(--governor-bay-700) 100%);
  width: 100vw;
  min-height: 100vh;
  height: 100%;
}

nav {
  padding: 30px;
}

nav a {
  font-weight: bold;
  color: #2c3e50;
}

nav a.router-link-exact-active {
  color: #42b983;
}

/* Menu */
.sidenav {
  height: 100%;
  width: 0;
  position: fixed;
  z-index: 1;
  top: 0;
  left: 0;
  background-color: #111;
  overflow-x: hidden;
  transition: 0.5s;
  padding-top: 60px;
}

.sidenav a {
  padding: 8px 8px 8px 32px;
  text-decoration: none;
  font-size: 25px;
  color: #818181;
  display: block;
  transition: 0.3s;
}

.sidenav a:hover {
  color: #f1f1f1;
}

.sidenav .closebtn {
  position: absolute;
  top: 0;
  right: 25px;
  font-size: 36px;
  margin-left: 50px;
}

@media screen and (max-height: 450px) {
  .sidenav {padding-top: 15px;}
  .sidenav a {font-size: 18px;}
}
</style>