import * as THREE from 'three'

export class Terrain extends THREE.Mesh {
    constructor(width, height)   {
        super()

        this.width = width
        this.height = height
        
        this.geometry = new THREE.PlaneGeometry(width, height, width, height)
        this.material = new THREE.MeshStandardMaterial({color: 'green'})
        this.rotateX(- Math.PI / 2)
    }
}