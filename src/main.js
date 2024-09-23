import * as THREE from 'three';
import { OrbitControls } from 'three/addons/controls/OrbitControls.js';
import Stats from 'three/addons/libs/stats.module.js'
import { GLTFLoader } from 'three/addons/loaders/GLTFLoader.js';
import { Terrain } from './terrain'

const scene = new THREE.Scene();
const camera = new THREE.PerspectiveCamera( 75, window.innerWidth / window.innerHeight, 0.1, 1000 );

const renderer = new THREE.WebGLRenderer();
renderer.setAnimationLoop(animate);
document.body.appendChild( renderer.domElement );

const stats = new Stats()
// document.body.appendChild(stats.dom)

const sizes = {
    width: window.innerWidth,
    height: window.innerHeight
}

renderer.setSize(sizes.width, sizes.height );

window.addEventListener('resize', () =>
    {
        // Update sizes
        sizes.width = window.innerWidth
        sizes.height = window.innerHeight
    
        // Update camera
        camera.aspect = sizes.width / sizes.height
        camera.updateProjectionMatrix()
    
        // Update renderer
        renderer.setSize(sizes.width, sizes.height)
        renderer.setPixelRatio(Math.min(window.devicePixelRatio, 2))
    })
    
const controls = new OrbitControls( camera, renderer.domElement );
const loader = new GLTFLoader();

// Lighting
const ambientLight = new THREE.AmbientLight('#ffffff', .3)
scene.add(ambientLight)

const directionalLight = new THREE.DirectionalLight('#ffffff', .7)
directionalLight.position.set(1,2,3)
scene.add(directionalLight)

// Meshes
const cube = new THREE.Mesh(
    new THREE.BoxGeometry(1,1,1),
    new THREE.MeshStandardMaterial({color: 'red'})
) 
scene.add(cube)

const terrain = new Terrain(10,10)
scene.add(terrain)

// Camera
camera.position.set(0,4,5)



function animate() {
    controls.update()
    renderer.render(scene, camera)
    stats.update()
}



