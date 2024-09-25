<?xml version="1.0" encoding="utf-8" standalone="yes" ?>
<!--Torque Constructor Scene document http://www.garagegames.com-->
<ConstructorScene version="4" creator="Torque Constructor" date="2024/09/23 18:55:08">
    <Sunlight azimuth="180" elevation="35" color="255 255 255" ambient="64 64 64" />
    <LightingOptions lightingSystem="" ineditor_defaultLightmapSize="256" ineditor_maxLightmapSize="256" ineditor_lightingPerformanceHint="0" ineditor_shadowPerformanceHint="1" ineditor_TAPCompatibility="0" ineditor_useSunlight="0" export_defaultLightmapSize="256" export_maxLightmapSize="256" export_lightingPerformanceHint="0" export_shadowPerformanceHint="1" export_TAPCompatibility="0" export_useSunlight="0" />
    <GameTypes>
        <GameType name="Constructor" />
        <GameType name="Torque" />
    </GameTypes>
    <DetailLevels current="0">
        <DetailLevel minPixelSize="0" actionCenter="0 0 0">
            <InteriorMap brushScale="32" lightScale="32" ambientColor="0 0 0" ambientColorEmerg="0 0 0">
                <Entities nextEntityID="1">
                    <Entity id="0" classname="worldspawn" gametype="Torque" isPointEntity="0">
                        <Properties detail_number="0" min_pixels="250" geometry_scale="32" light_geometry_scale="32" light_smoothing_scale="4.0" light_mesh_scale="1.0" ambient_color="0 0 0" emergency_ambient_color="0 0 0" mapversion="220" />
                    </Entity>
                </Entities>
                <Brushes nextBrushID="266">
                    <Brush id="1" owner="0" type="0" pos="0 0 6.5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 0 0 0 1 6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 6" />
                            <Vertex pos="4 4 -6" />
                            <Vertex pos="4 -4 6" />
                            <Vertex pos="4 -4 -6" />
                            <Vertex pos="-4 4 6" />
                            <Vertex pos="-4 4 -6" />
                            <Vertex pos="-4 -4 6" />
                            <Vertex pos="-4 -4 -6" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 512 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 512 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 512 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -6" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="2" owner="0" type="0" pos="5 0 7.5" rot="1 0 0 0" scale="" transform="1 0 0 5 0 1 0 0 0 0 1 7.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 4 5" />
                            <Vertex pos="1 4 -3" />
                            <Vertex pos="1 -4 5" />
                            <Vertex pos="1 -4 -3" />
                            <Vertex pos="-1 4 5" />
                            <Vertex pos="-1 4 -5" />
                            <Vertex pos="-1 -4 5" />
                            <Vertex pos="-1 -4 -5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 512 0 0 -1 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 384 0 0 -1 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 128 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -2.82843" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="3" owner="0" type="0" pos="10 -3.5 12" rot="1 0 0 0" scale="" transform="1 0 0 10 0 1 0 -3.5 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.5 0.5" />
                            <Vertex pos="4 0.5 -0.5" />
                            <Vertex pos="4 -0.5 0.5" />
                            <Vertex pos="4 -0.5 -0.5" />
                            <Vertex pos="-4 0.5 0.5" />
                            <Vertex pos="-4 0.5 -0.5" />
                            <Vertex pos="-4 -0.5 0.5" />
                            <Vertex pos="-4 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 1024 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 1024 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 1024 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 1024 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="4" owner="0" type="0" pos="10 3.5 12" rot="1 0 0 0" scale="" transform="1 0 0 10 0 1 0 3.5 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.5 0.5" />
                            <Vertex pos="4 0.5 -0.5" />
                            <Vertex pos="4 -0.5 0.5" />
                            <Vertex pos="4 -0.5 -0.5" />
                            <Vertex pos="-4 0.5 0.5" />
                            <Vertex pos="-4 0.5 -0.5" />
                            <Vertex pos="-4 -0.5 0.5" />
                            <Vertex pos="-4 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 1024 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 1024 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 1024 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 1024 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="5" owner="0" type="0" pos="10 -3.5 5" rot="1 0 0 0" scale="" transform="1 0 0 10 0 1 0 -3.5 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.5 0.5" />
                            <Vertex pos="4 0.5 -0.5" />
                            <Vertex pos="4 -0.5 0.5" />
                            <Vertex pos="4 -0.5 -0.5" />
                            <Vertex pos="-4 0.5 0.5" />
                            <Vertex pos="-4 0.5 -0.5" />
                            <Vertex pos="-4 -0.5 0.5" />
                            <Vertex pos="-4 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 1024 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 1024 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 1024 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 1024 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="6" owner="0" type="0" pos="10 3.5 5" rot="1 0 0 0" scale="" transform="1 0 0 10 0 1 0 3.5 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.5 0.5" />
                            <Vertex pos="4 0.5 -0.5" />
                            <Vertex pos="4 -0.5 0.5" />
                            <Vertex pos="4 -0.5 -0.5" />
                            <Vertex pos="-4 0.5 0.5" />
                            <Vertex pos="-4 0.5 -0.5" />
                            <Vertex pos="-4 -0.5 0.5" />
                            <Vertex pos="-4 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 1024 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 1024 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 1024 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 1024 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="11" owner="0" type="0" pos="14.5 -3.5 5" rot="1 0 0 0" scale="" transform="1 0 0 14.5 0 1 0 -3.5 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 -1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="12" owner="0" type="0" pos="14.5 3.5 5" rot="1 0 0 0" scale="" transform="1 0 0 14.5 0 1 0 3.5 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 -1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="13" owner="0" type="0" pos="14.5 -3.5 12" rot="1 0 0 0" scale="" transform="1 0 0 14.5 0 1 0 -3.5 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 -1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="14" owner="0" type="0" pos="14.5 3.5 12" rot="1 0 0 0" scale="" transform="1 0 0 14.5 0 1 0 3.5 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 -1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="17" owner="0" type="0" pos="27.5 -3.5 10" rot="1 0 0 0" scale="" transform="1 0 0 27.5 0 1 0 -3.5 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 -1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="18" owner="0" type="0" pos="27.5 3.5 10" rot="1 0 0 0" scale="" transform="1 0 0 27.5 0 1 0 3.5 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 -1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="19" owner="0" type="0" pos="27.5 -3.5 5" rot="1 0 0 0" scale="" transform="1 0 0 27.5 0 1 0 -3.5 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 -1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="20" owner="0" type="0" pos="27.5 3.5 5" rot="1 0 0 0" scale="" transform="1 0 0 27.5 0 1 0 3.5 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 -1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="23" owner="0" type="0" pos="21 -3.5 5" rot="1 0 0 0" scale="" transform="1 0 0 21 0 1 0 -3.5 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.5 0.5" />
                            <Vertex pos="6 0.5 -0.5" />
                            <Vertex pos="6 -0.5 0.5" />
                            <Vertex pos="6 -0.5 -0.5" />
                            <Vertex pos="-6 0.5 0.5" />
                            <Vertex pos="-6 0.5 -0.5" />
                            <Vertex pos="-6 -0.5 0.5" />
                            <Vertex pos="-6 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 1536 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 1536 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 1536 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 1536 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="24" owner="0" type="0" pos="21 3.5 5" rot="1 0 0 0" scale="" transform="1 0 0 21 0 1 0 3.5 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.5 0.5" />
                            <Vertex pos="6 0.5 -0.5" />
                            <Vertex pos="6 -0.5 0.5" />
                            <Vertex pos="6 -0.5 -0.5" />
                            <Vertex pos="-6 0.5 0.5" />
                            <Vertex pos="-6 0.5 -0.5" />
                            <Vertex pos="-6 -0.5 0.5" />
                            <Vertex pos="-6 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 1536 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 1536 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 1536 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 1536 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="27" owner="0" type="0" pos="32 -3.5 5" rot="1 0 0 0" scale="" transform="1 0 0 32 0 1 0 -3.5 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.5 0.5" />
                            <Vertex pos="4 0.5 -0.5" />
                            <Vertex pos="4 -0.5 0.5" />
                            <Vertex pos="4 -0.5 -0.5" />
                            <Vertex pos="-4 0.5 0.5" />
                            <Vertex pos="-4 0.5 -0.5" />
                            <Vertex pos="-4 -0.5 0.5" />
                            <Vertex pos="-4 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 1024 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 1024 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 1024 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 1024 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="28" owner="0" type="0" pos="32 3.5 5" rot="1 0 0 0" scale="" transform="1 0 0 32 0 1 0 3.5 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.5 0.5" />
                            <Vertex pos="4 0.5 -0.5" />
                            <Vertex pos="4 -0.5 0.5" />
                            <Vertex pos="4 -0.5 -0.5" />
                            <Vertex pos="-4 0.5 0.5" />
                            <Vertex pos="-4 0.5 -0.5" />
                            <Vertex pos="-4 -0.5 0.5" />
                            <Vertex pos="-4 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 1024 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 1024 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 1024 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 1024 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="29" owner="0" type="0" pos="36.5 0 5" rot="1 0 0 0" scale="" transform="1 0 0 36.5 0 1 0 0 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 3 0.5" />
                            <Vertex pos="0.5 3 -0.5" />
                            <Vertex pos="0.5 -3 0.5" />
                            <Vertex pos="0.5 -3 -0.5" />
                            <Vertex pos="-0.5 3 0.5" />
                            <Vertex pos="-0.5 3 -0.5" />
                            <Vertex pos="-0.5 -3 0.5" />
                            <Vertex pos="-0.5 -3 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="30" owner="0" type="0" pos="36.5 -3.5 10" rot="1 0 0 0" scale="" transform="1 0 0 36.5 0 1 0 -3.5 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 -1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="31" owner="0" type="0" pos="36.5 3.5 10" rot="1 0 0 0" scale="" transform="1 0 0 36.5 0 1 0 3.5 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 -1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="32" owner="0" type="0" pos="36.5 -3.5 5" rot="1 0 0 0" scale="" transform="1 0 0 36.5 0 1 0 -3.5 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 -1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="33" owner="0" type="0" pos="36.5 3.5 5" rot="1 0 0 0" scale="" transform="1 0 0 36.5 0 1 0 3.5 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 -1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="34" owner="0" type="0" pos="32 -3.5 10" rot="1 0 0 0" scale="" transform="1 0 0 32 0 1 0 -3.5 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.5 0.5" />
                            <Vertex pos="4 0.5 -0.5" />
                            <Vertex pos="4 -0.5 0.5" />
                            <Vertex pos="4 -0.5 -0.5" />
                            <Vertex pos="-4 0.5 0.5" />
                            <Vertex pos="-4 0.5 -0.5" />
                            <Vertex pos="-4 -0.5 0.5" />
                            <Vertex pos="-4 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 1024 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 1024 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 1024 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 1024 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="35" owner="0" type="0" pos="32 3.5 10" rot="1 0 0 0" scale="" transform="1 0 0 32 0 1 0 3.5 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.5 0.5" />
                            <Vertex pos="4 0.5 -0.5" />
                            <Vertex pos="4 -0.5 0.5" />
                            <Vertex pos="4 -0.5 -0.5" />
                            <Vertex pos="-4 0.5 0.5" />
                            <Vertex pos="-4 0.5 -0.5" />
                            <Vertex pos="-4 -0.5 0.5" />
                            <Vertex pos="-4 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 1024 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 1024 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 1024 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 1024 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="39" owner="0" type="0" pos="-10 -3.5 12" rot="1 0 0 0" scale="" transform="1 0 0 -10 0 1 0 -3.5 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.5 0.5" />
                            <Vertex pos="6 0.5 -0.5" />
                            <Vertex pos="6 -0.5 0.5" />
                            <Vertex pos="6 -0.5 -0.5" />
                            <Vertex pos="-6 0.5 0.5" />
                            <Vertex pos="-6 0.5 -0.5" />
                            <Vertex pos="-6 -0.5 0.5" />
                            <Vertex pos="-6 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 1536 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 1536 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 1536 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 1536 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="40" owner="0" type="0" pos="-10 3.5 12" rot="1 0 0 0" scale="" transform="1 0 0 -10 0 1 0 3.5 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.5 0.5" />
                            <Vertex pos="6 0.5 -0.5" />
                            <Vertex pos="6 -0.5 0.5" />
                            <Vertex pos="6 -0.5 -0.5" />
                            <Vertex pos="-6 0.5 0.5" />
                            <Vertex pos="-6 0.5 -0.5" />
                            <Vertex pos="-6 -0.5 0.5" />
                            <Vertex pos="-6 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 1536 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 1536 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 1536 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 1536 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="41" owner="0" type="0" pos="-10 -3.5 5" rot="1 0 0 0" scale="" transform="1 0 0 -10 0 1 0 -3.5 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.5 0.5" />
                            <Vertex pos="6 0.5 -0.5" />
                            <Vertex pos="6 -0.5 0.5" />
                            <Vertex pos="6 -0.5 -0.5" />
                            <Vertex pos="-6 0.5 0.5" />
                            <Vertex pos="-6 0.5 -0.5" />
                            <Vertex pos="-6 -0.5 0.5" />
                            <Vertex pos="-6 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 1536 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 1536 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 1536 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 1536 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="42" owner="0" type="0" pos="-10 3.5 5" rot="1 0 0 0" scale="" transform="1 0 0 -10 0 1 0 3.5 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.5 0.5" />
                            <Vertex pos="6 0.5 -0.5" />
                            <Vertex pos="6 -0.5 0.5" />
                            <Vertex pos="6 -0.5 -0.5" />
                            <Vertex pos="-6 0.5 0.5" />
                            <Vertex pos="-6 0.5 -0.5" />
                            <Vertex pos="-6 -0.5 0.5" />
                            <Vertex pos="-6 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 1536 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 1536 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 1536 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 1536 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="47" owner="0" type="0" pos="-16.5 -3.5 5" rot="1 0 0 0" scale="" transform="1 0 0 -16.5 0 1 0 -3.5 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 -1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="48" owner="0" type="0" pos="-16.5 3.5 5" rot="1 0 0 0" scale="" transform="1 0 0 -16.5 0 1 0 3.5 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 -1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="49" owner="0" type="0" pos="-16.5 -3.5 12" rot="1 0 0 0" scale="" transform="1 0 0 -16.5 0 1 0 -3.5 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 -1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="50" owner="0" type="0" pos="-16.5 3.5 12" rot="1 0 0 0" scale="" transform="1 0 0 -16.5 0 1 0 3.5 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 -1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="53" owner="0" type="0" pos="-20 -3.5 5" rot="1 0 0 0" scale="" transform="1 0 0 -20 0 1 0 -3.5 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.5 0.5" />
                            <Vertex pos="3 0.5 -0.5" />
                            <Vertex pos="3 -0.5 0.5" />
                            <Vertex pos="3 -0.5 -0.5" />
                            <Vertex pos="-3 0.5 0.5" />
                            <Vertex pos="-3 0.5 -0.5" />
                            <Vertex pos="-3 -0.5 0.5" />
                            <Vertex pos="-3 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="54" owner="0" type="0" pos="-20 3.5 5" rot="1 0 0 0" scale="" transform="1 0 0 -20 0 1 0 3.5 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.5 0.5" />
                            <Vertex pos="3 0.5 -0.5" />
                            <Vertex pos="3 -0.5 0.5" />
                            <Vertex pos="3 -0.5 -0.5" />
                            <Vertex pos="-3 0.5 0.5" />
                            <Vertex pos="-3 0.5 -0.5" />
                            <Vertex pos="-3 -0.5 0.5" />
                            <Vertex pos="-3 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="59" owner="0" type="0" pos="-23.5 -3.5 5" rot="1 0 0 0" scale="" transform="1 0 0 -23.5 0 1 0 -3.5 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 -1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="60" owner="0" type="0" pos="-23.5 3.5 5" rot="1 0 0 0" scale="" transform="1 0 0 -23.5 0 1 0 3.5 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 -1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="61" owner="0" type="0" pos="-23.5 -3.5 10" rot="1 0 0 0" scale="" transform="1 0 0 -23.5 0 1 0 -3.5 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 -1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="62" owner="0" type="0" pos="-23.5 3.5 10" rot="1 0 0 0" scale="" transform="1 0 0 -23.5 0 1 0 3.5 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 -1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="63" owner="0" type="0" pos="-29 -3.5 10" rot="1 0 0 0" scale="" transform="1 0 0 -29 0 1 0 -3.5 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.5 0.5" />
                            <Vertex pos="5 0.5 -0.5" />
                            <Vertex pos="5 -0.5 0.5" />
                            <Vertex pos="5 -0.5 -0.5" />
                            <Vertex pos="-5 0.5 0.5" />
                            <Vertex pos="-5 0.5 -0.5" />
                            <Vertex pos="-5 -0.5 0.5" />
                            <Vertex pos="-5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="64" owner="0" type="0" pos="-29 3.5 10" rot="1 0 0 0" scale="" transform="1 0 0 -29 0 1 0 3.5 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.5 0.5" />
                            <Vertex pos="5 0.5 -0.5" />
                            <Vertex pos="5 -0.5 0.5" />
                            <Vertex pos="5 -0.5 -0.5" />
                            <Vertex pos="-5 0.5 0.5" />
                            <Vertex pos="-5 0.5 -0.5" />
                            <Vertex pos="-5 -0.5 0.5" />
                            <Vertex pos="-5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="65" owner="0" type="0" pos="-29 -3.5 5" rot="1 0 0 0" scale="" transform="1 0 0 -29 0 1 0 -3.5 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.5 0.5" />
                            <Vertex pos="5 0.5 -0.5" />
                            <Vertex pos="5 -0.5 0.5" />
                            <Vertex pos="5 -0.5 -0.5" />
                            <Vertex pos="-5 0.5 0.5" />
                            <Vertex pos="-5 0.5 -0.5" />
                            <Vertex pos="-5 -0.5 0.5" />
                            <Vertex pos="-5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="66" owner="0" type="0" pos="-29 3.5 5" rot="1 0 0 0" scale="" transform="1 0 0 -29 0 1 0 3.5 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.5 0.5" />
                            <Vertex pos="5 0.5 -0.5" />
                            <Vertex pos="5 -0.5 0.5" />
                            <Vertex pos="5 -0.5 -0.5" />
                            <Vertex pos="-5 0.5 0.5" />
                            <Vertex pos="-5 0.5 -0.5" />
                            <Vertex pos="-5 -0.5 0.5" />
                            <Vertex pos="-5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="71" owner="0" type="0" pos="-34.5 -3.5 5" rot="1 0 0 0" scale="" transform="1 0 0 -34.5 0 1 0 -3.5 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 -1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="72" owner="0" type="0" pos="-34.5 3.5 5" rot="1 0 0 0" scale="" transform="1 0 0 -34.5 0 1 0 3.5 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 -1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="73" owner="0" type="0" pos="-34.5 -3.5 10" rot="1 0 0 0" scale="" transform="1 0 0 -34.5 0 1 0 -3.5 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 -1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="74" owner="0" type="0" pos="-34.5 3.5 10" rot="1 0 0 0" scale="" transform="1 0 0 -34.5 0 1 0 3.5 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 -1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="77" owner="0" type="0" pos="-38 -3.5 5" rot="1 0 0 0" scale="" transform="1 0 0 -38 0 1 0 -3.5 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.5 0.5" />
                            <Vertex pos="3 0.5 -0.5" />
                            <Vertex pos="3 -0.5 0.5" />
                            <Vertex pos="3 -0.5 -0.5" />
                            <Vertex pos="-3 0.5 0.5" />
                            <Vertex pos="-3 0.5 -0.5" />
                            <Vertex pos="-3 -0.5 0.5" />
                            <Vertex pos="-3 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="78" owner="0" type="0" pos="-38 3.5 5" rot="1 0 0 0" scale="" transform="1 0 0 -38 0 1 0 3.5 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.5 0.5" />
                            <Vertex pos="3 0.5 -0.5" />
                            <Vertex pos="3 -0.5 0.5" />
                            <Vertex pos="3 -0.5 -0.5" />
                            <Vertex pos="-3 0.5 0.5" />
                            <Vertex pos="-3 0.5 -0.5" />
                            <Vertex pos="-3 -0.5 0.5" />
                            <Vertex pos="-3 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="80" owner="0" type="0" pos="-41.5 -3.5 5" rot="1 0 0 0" scale="" transform="1 0 0 -41.5 0 1 0 -3.5 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 -1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="81" owner="0" type="0" pos="-41.5 3.5 5" rot="1 0 0 0" scale="" transform="1 0 0 -41.5 0 1 0 3.5 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 -1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="84" owner="0" type="0" pos="-41.5 -3.5 8" rot="1 0 0 0" scale="" transform="1 0 0 -41.5 0 1 0 -3.5 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 -1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="85" owner="0" type="0" pos="-41.5 3.5 8" rot="1 0 0 0" scale="" transform="1 0 0 -41.5 0 1 0 3.5 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 -1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="86" owner="0" type="0" pos="-47 -3.5 8" rot="1 0 0 0" scale="" transform="1 0 0 -47 0 1 0 -3.5 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.5 0.5" />
                            <Vertex pos="5 0.5 -0.5" />
                            <Vertex pos="5 -0.5 0.5" />
                            <Vertex pos="5 -0.5 -0.5" />
                            <Vertex pos="-5 0.5 0.5" />
                            <Vertex pos="-5 0.5 -0.5" />
                            <Vertex pos="-5 -0.5 0.5" />
                            <Vertex pos="-5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="87" owner="0" type="0" pos="-47 3.5 8" rot="1 0 0 0" scale="" transform="1 0 0 -47 0 1 0 3.5 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.5 0.5" />
                            <Vertex pos="5 0.5 -0.5" />
                            <Vertex pos="5 -0.5 0.5" />
                            <Vertex pos="5 -0.5 -0.5" />
                            <Vertex pos="-5 0.5 0.5" />
                            <Vertex pos="-5 0.5 -0.5" />
                            <Vertex pos="-5 -0.5 0.5" />
                            <Vertex pos="-5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="88" owner="0" type="0" pos="-47 -3.5 5" rot="1 0 0 0" scale="" transform="1 0 0 -47 0 1 0 -3.5 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.5 0.5" />
                            <Vertex pos="5 0.5 -0.5" />
                            <Vertex pos="5 -0.5 0.5" />
                            <Vertex pos="5 -0.5 -0.5" />
                            <Vertex pos="-5 0.5 0.5" />
                            <Vertex pos="-5 0.5 -0.5" />
                            <Vertex pos="-5 -0.5 0.5" />
                            <Vertex pos="-5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="89" owner="0" type="0" pos="-47 3.5 5" rot="1 0 0 0" scale="" transform="1 0 0 -47 0 1 0 3.5 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.5 0.5" />
                            <Vertex pos="5 0.5 -0.5" />
                            <Vertex pos="5 -0.5 0.5" />
                            <Vertex pos="5 -0.5 -0.5" />
                            <Vertex pos="-5 0.5 0.5" />
                            <Vertex pos="-5 0.5 -0.5" />
                            <Vertex pos="-5 -0.5 0.5" />
                            <Vertex pos="-5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="91" owner="0" type="0" pos="-52.5 3.5 6.5" rot="1 0 0 0" scale="" transform="1 0 0 -52.5 0 1 0 3.5 0 0 1 6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 1" />
                            <Vertex pos="0.5 0.5 -1" />
                            <Vertex pos="0.5 -0.5 1" />
                            <Vertex pos="0.5 -0.5 -1" />
                            <Vertex pos="-0.5 0.5 1" />
                            <Vertex pos="-0.5 0.5 -1" />
                            <Vertex pos="-0.5 -0.5 1" />
                            <Vertex pos="-0.5 -0.5 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="94" owner="0" type="0" pos="-52.5 -3.5 5" rot="1 0 0 0" scale="" transform="1 0 0 -52.5 0 1 0 -3.5 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 -1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="95" owner="0" type="0" pos="-52.5 3.5 5" rot="1 0 0 0" scale="" transform="1 0 0 -52.5 0 1 0 3.5 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 -1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="96" owner="0" type="0" pos="-52.5 -3.5 8" rot="1 0 0 0" scale="" transform="1 0 0 -52.5 0 1 0 -3.5 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 -1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="97" owner="0" type="0" pos="-52.5 3.5 8" rot="1 0 0 0" scale="" transform="1 0 0 -52.5 0 1 0 3.5 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 -1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="116" owner="0" type="0" pos="-52.5 0 6" rot="1 0 0 0" scale="" transform="1 0 0 -52.5 0 1 0 0 0 0 1 6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 1.5 1.5" />
                            <Vertex pos="1.5 1.5 -1.5" />
                            <Vertex pos="1.5 -1.5 1.5" />
                            <Vertex pos="1.5 -1.5 -1.5" />
                            <Vertex pos="-1.5 1.5 1.5" />
                            <Vertex pos="-1.5 1.5 -1.5" />
                            <Vertex pos="-1.5 -1.5 1.5" />
                            <Vertex pos="-1.5 -1.5 -1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 128 0 0.375 0.375" texRot="0" texScale="0.375 0.375" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 128 0 0.375 0.375" texRot="0" texScale="0.375 0.375" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 128 0 0.375 0.375" texRot="0" texScale="0.375 0.375" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 128 0 0.375 0.375" texRot="0" texScale="0.375 0.375" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.5" album="Blasted" material="bm_grid_blank4" texgens="0 -0.999999 0 128 -0.999999 0 0 128 0 0.375 0.375" texRot="0" texScale="0.375 0.375" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1.5" album="Blasted" material="bm_grid_blank4" texgens="0 -0.999999 0 128 0.999999 0 0 128 0 0.375 0.375" texRot="0" texScale="0.375 0.375" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="117" owner="0" type="0" pos="-3.5 -3.5 16.5" rot="1 0 0 0" scale="" transform="1 0 0 -3.5 0 1 0 -3.5 0 0 1 16.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 4" />
                            <Vertex pos="0.5 0.5 -4" />
                            <Vertex pos="0.5 -0.5 4" />
                            <Vertex pos="0.5 -0.5 -4" />
                            <Vertex pos="-0.5 0.5 4" />
                            <Vertex pos="-0.5 0.5 -4" />
                            <Vertex pos="-0.5 -0.5 4" />
                            <Vertex pos="-0.5 -0.5 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="118" owner="0" type="0" pos="-3.5 3.5 16.5" rot="1 0 0 0" scale="" transform="1 0 0 -3.5 0 1 0 3.5 0 0 1 16.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 4" />
                            <Vertex pos="0.5 0.5 -4" />
                            <Vertex pos="0.5 -0.5 4" />
                            <Vertex pos="0.5 -0.5 -4" />
                            <Vertex pos="-0.5 0.5 4" />
                            <Vertex pos="-0.5 0.5 -4" />
                            <Vertex pos="-0.5 -0.5 4" />
                            <Vertex pos="-0.5 -0.5 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="119" owner="0" type="0" pos="-3.5 0 21" rot="1 0 0 0" scale="" transform="1 0 0 -3.5 0 1 0 0 0 0 1 21 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 3 0.5" />
                            <Vertex pos="0.5 3 -0.5" />
                            <Vertex pos="0.5 -3 0.5" />
                            <Vertex pos="0.5 -3 -0.5" />
                            <Vertex pos="-0.5 3 0.5" />
                            <Vertex pos="-0.5 3 -0.5" />
                            <Vertex pos="-0.5 -3 0.5" />
                            <Vertex pos="-0.5 -3 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="120" owner="0" type="0" pos="-3.5 -3.5 21" rot="1 0 0 0" scale="" transform="1 0 0 -3.5 0 1 0 -3.5 0 0 1 21 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 -1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="121" owner="0" type="0" pos="-3.5 3.5 21" rot="1 0 0 0" scale="" transform="1 0 0 -3.5 0 1 0 3.5 0 0 1 21 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 -1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="122" owner="0" type="0" pos="5.5 -3.5 16.5" rot="1 0 0 0" scale="" transform="1 0 0 5.5 0 1 0 -3.5 0 0 1 16.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 4" />
                            <Vertex pos="0.5 0.5 -4" />
                            <Vertex pos="0.5 -0.5 4" />
                            <Vertex pos="0.5 -0.5 -4" />
                            <Vertex pos="-0.5 0.5 4" />
                            <Vertex pos="-0.5 0.5 -4" />
                            <Vertex pos="-0.5 -0.5 4" />
                            <Vertex pos="-0.5 -0.5 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="123" owner="0" type="0" pos="5.5 3.5 16.5" rot="1 0 0 0" scale="" transform="1 0 0 5.5 0 1 0 3.5 0 0 1 16.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 4" />
                            <Vertex pos="0.5 0.5 -4" />
                            <Vertex pos="0.5 -0.5 4" />
                            <Vertex pos="0.5 -0.5 -4" />
                            <Vertex pos="-0.5 0.5 4" />
                            <Vertex pos="-0.5 0.5 -4" />
                            <Vertex pos="-0.5 -0.5 4" />
                            <Vertex pos="-0.5 -0.5 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="124" owner="0" type="0" pos="5.5 0 21" rot="1 0 0 0" scale="" transform="1 0 0 5.5 0 1 0 0 0 0 1 21 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 3 0.5" />
                            <Vertex pos="0.5 3 -0.5" />
                            <Vertex pos="0.5 -3 0.5" />
                            <Vertex pos="0.5 -3 -0.5" />
                            <Vertex pos="-0.5 3 0.5" />
                            <Vertex pos="-0.5 3 -0.5" />
                            <Vertex pos="-0.5 -3 0.5" />
                            <Vertex pos="-0.5 -3 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="125" owner="0" type="0" pos="5.5 -3.5 21" rot="1 0 0 0" scale="" transform="1 0 0 5.5 0 1 0 -3.5 0 0 1 21 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 -1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="126" owner="0" type="0" pos="5.5 3.5 21" rot="1 0 0 0" scale="" transform="1 0 0 5.5 0 1 0 3.5 0 0 1 21 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 -1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="127" owner="0" type="0" pos="1 0 25" rot="1 0 0 0" scale="" transform="1 0 0 1 0 1 0 0 0 0 1 25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 3 0.5" />
                            <Vertex pos="0.5 3 -0.5" />
                            <Vertex pos="0.5 -3 0.5" />
                            <Vertex pos="0.5 -3 -0.5" />
                            <Vertex pos="-0.5 3 0.5" />
                            <Vertex pos="-0.5 3 -0.5" />
                            <Vertex pos="-0.5 -3 0.5" />
                            <Vertex pos="-0.5 -3 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="128" owner="0" type="0" pos="1 -3.5 25" rot="1 0 0 0" scale="" transform="1 0 0 1 0 1 0 -3.5 0 0 1 25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 -1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="129" owner="0" type="0" pos="1 3.5 25" rot="1 0 0 0" scale="" transform="1 0 0 1 0 1 0 3.5 0 0 1 25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 -1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="134" owner="0" type="0" pos="1 -3.5 26.5" rot="1 0 0 0" scale="" transform="1 0 0 1 0 1 0 -3.5 0 0 1 26.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 1" />
                            <Vertex pos="0.5 0.5 -1" />
                            <Vertex pos="0.5 -0.5 1" />
                            <Vertex pos="0.5 -0.5 -1" />
                            <Vertex pos="-0.5 0.5 1" />
                            <Vertex pos="-0.5 0.5 -1" />
                            <Vertex pos="-0.5 -0.5 1" />
                            <Vertex pos="-0.5 -0.5 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="135" owner="0" type="0" pos="1 3.5 26.5" rot="1 0 0 0" scale="" transform="1 0 0 1 0 1 0 3.5 0 0 1 26.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 1" />
                            <Vertex pos="0.5 0.5 -1" />
                            <Vertex pos="0.5 -0.5 1" />
                            <Vertex pos="0.5 -0.5 -1" />
                            <Vertex pos="-0.5 0.5 1" />
                            <Vertex pos="-0.5 0.5 -1" />
                            <Vertex pos="-0.5 -0.5 1" />
                            <Vertex pos="-0.5 -0.5 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="136" owner="0" type="0" pos="1 0 28" rot="1 0 0 0" scale="" transform="1 0 0 1 0 1 0 0 0 0 1 28 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 3 0.5" />
                            <Vertex pos="0.5 3 -0.5" />
                            <Vertex pos="0.5 -3 0.5" />
                            <Vertex pos="0.5 -3 -0.5" />
                            <Vertex pos="-0.5 3 0.5" />
                            <Vertex pos="-0.5 3 -0.5" />
                            <Vertex pos="-0.5 -3 0.5" />
                            <Vertex pos="-0.5 -3 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="137" owner="0" type="0" pos="1 -3.5 28" rot="1 0 0 0" scale="" transform="1 0 0 1 0 1 0 -3.5 0 0 1 28 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 -1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="138" owner="0" type="0" pos="1 3.5 28" rot="1 0 0 0" scale="" transform="1 0 0 1 0 1 0 3.5 0 0 1 28 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 -1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="139" owner="0" type="0" pos="19.0625 -3.5 19.1875" rot="1 0 0 0" scale="" transform="1 0 0 19.0625 0 1 0 -3.5 0 0 1 19.1875 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="17.5625 0.125 -8.6875" />
                            <Vertex pos="17.5625 0.125 -8.9375" />
                            <Vertex pos="17.5625 -0.125 -8.6875" />
                            <Vertex pos="17.5625 -0.125 -8.9375" />
                            <Vertex pos="-17.5625 0.125 8.9375" />
                            <Vertex pos="-17.5625 0.125 8.6875" />
                            <Vertex pos="-17.5625 -0.125 8.9375" />
                            <Vertex pos="-17.5625 -0.125 8.6875" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -17.5625" album="Blasted" material="bm_wood" texgens="0 0 -1 -4912 0 -1 0 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -17.5625" album="Blasted" material="bm_wood" texgens="0 0 -1 -4912 0 1 0 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 -1 -4912 1 0 0 4880 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 -1 -4912 -1 0 0 -4880 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.448485 0 0.89379 -0.111724" album="Blasted" material="bm_wood" texgens="1 0 0 4880 0 -1 0 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.448485 0 -0.89379 -0.111724" album="Blasted" material="bm_wood" texgens="-1 0 0 -4880 0 -1 0 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="140" owner="0" type="0" pos="-26.0625 -3.5 18.1875" rot="1 0 0 0" scale="" transform="1 0 0 -26.0625 0 1 0 -3.5 0 0 1 18.1875 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="26.5625 0.125 9.9375" />
                            <Vertex pos="26.5625 0.125 9.6875" />
                            <Vertex pos="26.5625 -0.125 9.9375" />
                            <Vertex pos="26.5625 -0.125 9.6875" />
                            <Vertex pos="-26.5625 0.125 -9.6875" />
                            <Vertex pos="-26.5625 0.125 -9.9375" />
                            <Vertex pos="-26.5625 -0.125 -9.6875" />
                            <Vertex pos="-26.5625 -0.125 -9.9375" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -26.5625" album="Blasted" material="bm_wood" texgens="0 0 -1 -4656 0 -1 0 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -26.5625" album="Blasted" material="bm_wood" texgens="0 0 -1 -4656 0 1 0 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 -1 -4656 1 0 0 -6672 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 -1 -4656 -1 0 0 6672 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.346523 0 0.938041 -0.117255" album="Blasted" material="bm_wood" texgens="1 0 0 -6672 0 -1 0 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.346523 0 -0.938041 -0.117255" album="Blasted" material="bm_wood" texgens="-1 0 0 6672 0 -1 0 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="141" owner="0" type="0" pos="19.0625 3.5 19.1875" rot="1 0 0 0" scale="" transform="1 0 0 19.0625 0 1 0 3.5 0 0 1 19.1875 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="17.5625 0.125 -8.6875" />
                            <Vertex pos="17.5625 0.125 -8.9375" />
                            <Vertex pos="17.5625 -0.125 -8.6875" />
                            <Vertex pos="17.5625 -0.125 -8.9375" />
                            <Vertex pos="-17.5625 0.125 8.9375" />
                            <Vertex pos="-17.5625 0.125 8.6875" />
                            <Vertex pos="-17.5625 -0.125 8.9375" />
                            <Vertex pos="-17.5625 -0.125 8.6875" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -17.5625" album="Blasted" material="bm_wood" texgens="0 0 -1 -4912 0 -1 0 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -17.5625" album="Blasted" material="bm_wood" texgens="0 0 -1 -4912 0 1 0 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 -1 -4912 1 0 0 4880 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 -1 -4912 -1 0 0 -4880 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.448485 0 0.89379 -0.111724" album="Blasted" material="bm_wood" texgens="1 0 0 4880 0 -1 0 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.448485 0 -0.89379 -0.111724" album="Blasted" material="bm_wood" texgens="-1 0 0 -4880 0 -1 0 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="142" owner="0" type="0" pos="-26.0625 3.5 18.1875" rot="1 0 0 0" scale="" transform="1 0 0 -26.0625 0 1 0 3.5 0 0 1 18.1875 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="26.5625 0.125 9.9375" />
                            <Vertex pos="26.5625 0.125 9.6875" />
                            <Vertex pos="26.5625 -0.125 9.9375" />
                            <Vertex pos="26.5625 -0.125 9.6875" />
                            <Vertex pos="-26.5625 0.125 -9.6875" />
                            <Vertex pos="-26.5625 0.125 -9.9375" />
                            <Vertex pos="-26.5625 -0.125 -9.6875" />
                            <Vertex pos="-26.5625 -0.125 -9.9375" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -26.5625" album="Blasted" material="bm_wood" texgens="0 0 -1 -4656 0 -1 0 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -26.5625" album="Blasted" material="bm_wood" texgens="0 0 -1 -4656 0 1 0 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 -1 -4656 1 0 0 -6672 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 -1 -4656 -1 0 0 6672 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.346523 0 0.938041 -0.117255" album="Blasted" material="bm_wood" texgens="1 0 0 -6672 0 -1 0 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.346523 0 -0.938041 -0.117255" album="Blasted" material="bm_wood" texgens="-1 0 0 6672 0 -1 0 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="143" owner="0" type="0" pos="-52.5 0 -33.5" rot="1 0 0 0" scale="" transform="1 0 0 -52.5 0 1 0 0 0 0 1 -33.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 0.125 38" />
                            <Vertex pos="0.125 0.125 2" />
                            <Vertex pos="0.125 -0.125 38" />
                            <Vertex pos="0.125 -0.125 2" />
                            <Vertex pos="-0.125 0.125 38" />
                            <Vertex pos="-0.125 0.125 2" />
                            <Vertex pos="-0.125 -0.125 38" />
                            <Vertex pos="-0.125 -0.125 2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="Blasted" material="bm_wood" texgens="0 1 0 0 0 0 -1 8576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="Blasted" material="bm_wood" texgens="0 -1 0 0 0 0 -1 8576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="Blasted" material="bm_wood" texgens="-1 0 0 13440 0 0 -1 8576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="Blasted" material="bm_wood" texgens="1 0 0 -13440 0 0 -1 8576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -38" album="Blasted" material="bm_wood" texgens="0 -1 0 0 -1 0 0 13440 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 2" album="Blasted" material="bm_wood" texgens="0 -1 0 0 1 0 0 -13440 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="144" owner="0" type="0" pos="-52.5 0 -32" rot="1 0 0 0" scale="" transform="1 0 0 -52.5 0 1 0 0 0 0 1 -32 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 -1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="146" owner="0" type="0" pos="-54.25 -8.25 -36.5" rot="1 0 0 0" scale="" transform="1 0 0 -54.25 0 1 0 -8.25 0 0 1 -36.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.875 8.375 4" />
                            <Vertex pos="0.75 1.875 -4" />
                            <Vertex pos="1.875 8.125 4" />
                            <Vertex pos="0.75 1.625 -4" />
                            <Vertex pos="1.625 8.375 4" />
                            <Vertex pos="0.5 1.875 -4" />
                            <Vertex pos="1.625 8.125 4" />
                            <Vertex pos="0.5 1.625 -4" />
                        </Vertices>
                        <Face id="0" plane="0.990257 0 -0.139255 -1.29971" album="Blasted" material="bm_wood" texgens="0 1 0 -2112 0 0 -1 9344 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.990257 0 0.139255 1.05215" album="Blasted" material="bm_wood" texgens="0 -1 0 2112 0 0 -1 9344 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 0.776114 -0.630593 -3.97758" album="Blasted" material="bm_wood" texgens="-1 0 0 13888 0 0 -1 9344 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.776114 0.630593 3.78356" album="Blasted" material="bm_wood" texgens="1 0 0 -13888 0 0 -1 9344 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="Blasted" material="bm_wood" texgens="0 -1 0 2112 -1 0 0 13888 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="Blasted" material="bm_wood" texgens="0 -1 0 2112 1 0 0 -13888 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="147" owner="0" type="0" pos="-54.25 8.25 -36.5" rot="1 0 0 0" scale="" transform="1 0 0 -54.25 0 1 0 8.25 0 0 1 -36.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.875 -8.125 4" />
                            <Vertex pos="0.75 -1.625 -4" />
                            <Vertex pos="1.875 -8.375 4" />
                            <Vertex pos="0.75 -1.875 -4" />
                            <Vertex pos="1.625 -8.125 4" />
                            <Vertex pos="0.5 -1.625 -4" />
                            <Vertex pos="1.625 -8.375 4" />
                            <Vertex pos="0.5 -1.875 -4" />
                        </Vertices>
                        <Face id="0" plane="0.990257 0 -0.139255 -1.29971" album="Blasted" material="bm_wood" texgens="0 1 0 2112 0 0 -1 9344 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.990257 0 0.139255 1.05215" album="Blasted" material="bm_wood" texgens="0 -1 0 -2112 0 0 -1 9344 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 0.776114 0.630593 3.78356" album="Blasted" material="bm_wood" texgens="-1 0 0 13888 0 0 -1 9344 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.776114 -0.630593 -3.97758" album="Blasted" material="bm_wood" texgens="1 0 0 -13888 0 0 -1 9344 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="Blasted" material="bm_wood" texgens="0 -1 0 -2112 -1 0 0 13888 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="Blasted" material="bm_wood" texgens="0 -1 0 -2112 1 0 0 -13888 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="148" owner="0" type="0" pos="-50.75 -8.25 -36.5" rot="1 0 0 0" scale="" transform="1 0 0 -50.75 0 1 0 -8.25 0 0 1 -36.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.625 8.375 4" />
                            <Vertex pos="-0.5 1.875 -4" />
                            <Vertex pos="-1.625 8.125 4" />
                            <Vertex pos="-0.5 1.625 -4" />
                            <Vertex pos="-1.875 8.375 4" />
                            <Vertex pos="-0.75 1.875 -4" />
                            <Vertex pos="-1.875 8.125 4" />
                            <Vertex pos="-0.75 1.625 -4" />
                        </Vertices>
                        <Face id="0" plane="0.990257 -0 0.139255 1.05215" album="Blasted" material="bm_wood" texgens="0 1 0 -2112 0 0 -1 9344 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.990257 -0 -0.139255 -1.29971" album="Blasted" material="bm_wood" texgens="0 -1 0 2112 0 0 -1 9344 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 0.776114 -0.630593 -3.97758" album="Blasted" material="bm_wood" texgens="-1 0 0 12992 0 0 -1 9344 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.776114 0.630593 3.78356" album="Blasted" material="bm_wood" texgens="1 0 0 -12992 0 0 -1 9344 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="Blasted" material="bm_wood" texgens="0 -1 0 2112 -1 0 0 12992 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="Blasted" material="bm_wood" texgens="0 -1 0 2112 1 0 0 -12992 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="149" owner="0" type="0" pos="-50.75 8.25 -36.5" rot="1 0 0 0" scale="" transform="1 0 0 -50.75 0 1 0 8.25 0 0 1 -36.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.625 -8.125 4" />
                            <Vertex pos="-0.5 -1.625 -4" />
                            <Vertex pos="-1.625 -8.375 4" />
                            <Vertex pos="-0.5 -1.875 -4" />
                            <Vertex pos="-1.875 -8.125 4" />
                            <Vertex pos="-0.75 -1.625 -4" />
                            <Vertex pos="-1.875 -8.375 4" />
                            <Vertex pos="-0.75 -1.875 -4" />
                        </Vertices>
                        <Face id="0" plane="0.990257 -0 0.139255 1.05215" album="Blasted" material="bm_wood" texgens="0 1 0 2112 0 0 -1 9344 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.990257 -0 -0.139255 -1.29971" album="Blasted" material="bm_wood" texgens="0 -1 0 -2112 0 0 -1 9344 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 0.776114 0.630593 3.78356" album="Blasted" material="bm_wood" texgens="-1 0 0 12992 0 0 -1 9344 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.776114 -0.630593 -3.97758" album="Blasted" material="bm_wood" texgens="1 0 0 -12992 0 0 -1 9344 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="Blasted" material="bm_wood" texgens="0 -1 0 -2112 -1 0 0 12992 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="Blasted" material="bm_wood" texgens="0 -1 0 -2112 1 0 0 -12992 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="150" owner="0" type="0" pos="-52.5 -3.5 6.5" rot="1 0 0 0" scale="" transform="1 0 0 -52.5 0 1 0 -3.5 0 0 1 6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 1" />
                            <Vertex pos="0.5 0.5 -1" />
                            <Vertex pos="0.5 -0.5 1" />
                            <Vertex pos="0.5 -0.5 -1" />
                            <Vertex pos="-0.5 0.5 1" />
                            <Vertex pos="-0.5 0.5 -1" />
                            <Vertex pos="-0.5 -0.5 1" />
                            <Vertex pos="-0.5 -0.5 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="151" owner="0" type="0" pos="-41.5 3.5 6.5" rot="1 0 0 0" scale="" transform="1 0 0 -41.5 0 1 0 3.5 0 0 1 6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 1" />
                            <Vertex pos="0.5 0.5 -1" />
                            <Vertex pos="0.5 -0.5 1" />
                            <Vertex pos="0.5 -0.5 -1" />
                            <Vertex pos="-0.5 0.5 1" />
                            <Vertex pos="-0.5 0.5 -1" />
                            <Vertex pos="-0.5 -0.5 1" />
                            <Vertex pos="-0.5 -0.5 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="152" owner="0" type="0" pos="-41.5 -3.5 6.5" rot="1 0 0 0" scale="" transform="1 0 0 -41.5 0 1 0 -3.5 0 0 1 6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 1" />
                            <Vertex pos="0.5 0.5 -1" />
                            <Vertex pos="0.5 -0.5 1" />
                            <Vertex pos="0.5 -0.5 -1" />
                            <Vertex pos="-0.5 0.5 1" />
                            <Vertex pos="-0.5 0.5 -1" />
                            <Vertex pos="-0.5 -0.5 1" />
                            <Vertex pos="-0.5 -0.5 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="153" owner="0" type="0" pos="-34.5 3.5 6.5" rot="1 0 0 0" scale="" transform="1 0 0 -34.5 0 1 0 3.5 0 0 1 6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 3" />
                            <Vertex pos="0.5 0.5 -1" />
                            <Vertex pos="0.5 -0.5 3" />
                            <Vertex pos="0.5 -0.5 -1" />
                            <Vertex pos="-0.5 0.5 3" />
                            <Vertex pos="-0.5 0.5 -1" />
                            <Vertex pos="-0.5 -0.5 3" />
                            <Vertex pos="-0.5 -0.5 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="154" owner="0" type="0" pos="-34.5 -3.5 6.5" rot="1 0 0 0" scale="" transform="1 0 0 -34.5 0 1 0 -3.5 0 0 1 6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 3" />
                            <Vertex pos="0.5 0.5 -1" />
                            <Vertex pos="0.5 -0.5 3" />
                            <Vertex pos="0.5 -0.5 -1" />
                            <Vertex pos="-0.5 0.5 3" />
                            <Vertex pos="-0.5 0.5 -1" />
                            <Vertex pos="-0.5 -0.5 3" />
                            <Vertex pos="-0.5 -0.5 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="155" owner="0" type="0" pos="-23.5 3.5 6.5" rot="1 0 0 0" scale="" transform="1 0 0 -23.5 0 1 0 3.5 0 0 1 6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 3" />
                            <Vertex pos="0.5 0.5 -1" />
                            <Vertex pos="0.5 -0.5 3" />
                            <Vertex pos="0.5 -0.5 -1" />
                            <Vertex pos="-0.5 0.5 3" />
                            <Vertex pos="-0.5 0.5 -1" />
                            <Vertex pos="-0.5 -0.5 3" />
                            <Vertex pos="-0.5 -0.5 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="156" owner="0" type="0" pos="-23.5 -3.5 6.5" rot="1 0 0 0" scale="" transform="1 0 0 -23.5 0 1 0 -3.5 0 0 1 6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 3" />
                            <Vertex pos="0.5 0.5 -1" />
                            <Vertex pos="0.5 -0.5 3" />
                            <Vertex pos="0.5 -0.5 -1" />
                            <Vertex pos="-0.5 0.5 3" />
                            <Vertex pos="-0.5 0.5 -1" />
                            <Vertex pos="-0.5 -0.5 3" />
                            <Vertex pos="-0.5 -0.5 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="157" owner="0" type="0" pos="-16.5 3.5 6.5" rot="1 0 0 0" scale="" transform="1 0 0 -16.5 0 1 0 3.5 0 0 1 6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 5" />
                            <Vertex pos="0.5 0.5 -1" />
                            <Vertex pos="0.5 -0.5 5" />
                            <Vertex pos="0.5 -0.5 -1" />
                            <Vertex pos="-0.5 0.5 5" />
                            <Vertex pos="-0.5 0.5 -1" />
                            <Vertex pos="-0.5 -0.5 5" />
                            <Vertex pos="-0.5 -0.5 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="158" owner="0" type="0" pos="-16.5 -3.5 6.5" rot="1 0 0 0" scale="" transform="1 0 0 -16.5 0 1 0 -3.5 0 0 1 6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 5" />
                            <Vertex pos="0.5 0.5 -1" />
                            <Vertex pos="0.5 -0.5 5" />
                            <Vertex pos="0.5 -0.5 -1" />
                            <Vertex pos="-0.5 0.5 5" />
                            <Vertex pos="-0.5 0.5 -1" />
                            <Vertex pos="-0.5 -0.5 5" />
                            <Vertex pos="-0.5 -0.5 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="159" owner="0" type="0" pos="14.5 3.5 6.5" rot="1 0 0 0" scale="" transform="1 0 0 14.5 0 1 0 3.5 0 0 1 6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 5" />
                            <Vertex pos="0.5 0.5 -1" />
                            <Vertex pos="0.5 -0.5 5" />
                            <Vertex pos="0.5 -0.5 -1" />
                            <Vertex pos="-0.5 0.5 5" />
                            <Vertex pos="-0.5 0.5 -1" />
                            <Vertex pos="-0.5 -0.5 5" />
                            <Vertex pos="-0.5 -0.5 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="160" owner="0" type="0" pos="14.5 -3.5 6.5" rot="1 0 0 0" scale="" transform="1 0 0 14.5 0 1 0 -3.5 0 0 1 6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 5" />
                            <Vertex pos="0.5 0.5 -1" />
                            <Vertex pos="0.5 -0.5 5" />
                            <Vertex pos="0.5 -0.5 -1" />
                            <Vertex pos="-0.5 0.5 5" />
                            <Vertex pos="-0.5 0.5 -1" />
                            <Vertex pos="-0.5 -0.5 5" />
                            <Vertex pos="-0.5 -0.5 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="161" owner="0" type="0" pos="27.5 3.5 6.5" rot="1 0 0 0" scale="" transform="1 0 0 27.5 0 1 0 3.5 0 0 1 6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 3" />
                            <Vertex pos="0.5 0.5 -1" />
                            <Vertex pos="0.5 -0.5 3" />
                            <Vertex pos="0.5 -0.5 -1" />
                            <Vertex pos="-0.5 0.5 3" />
                            <Vertex pos="-0.5 0.5 -1" />
                            <Vertex pos="-0.5 -0.5 3" />
                            <Vertex pos="-0.5 -0.5 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="162" owner="0" type="0" pos="27.5 -3.5 6.5" rot="1 0 0 0" scale="" transform="1 0 0 27.5 0 1 0 -3.5 0 0 1 6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 3" />
                            <Vertex pos="0.5 0.5 -1" />
                            <Vertex pos="0.5 -0.5 3" />
                            <Vertex pos="0.5 -0.5 -1" />
                            <Vertex pos="-0.5 0.5 3" />
                            <Vertex pos="-0.5 0.5 -1" />
                            <Vertex pos="-0.5 -0.5 3" />
                            <Vertex pos="-0.5 -0.5 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="163" owner="0" type="0" pos="36.5 3.5 6.5" rot="1 0 0 0" scale="" transform="1 0 0 36.5 0 1 0 3.5 0 0 1 6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 3" />
                            <Vertex pos="0.5 0.5 -1" />
                            <Vertex pos="0.5 -0.5 3" />
                            <Vertex pos="0.5 -0.5 -1" />
                            <Vertex pos="-0.5 0.5 3" />
                            <Vertex pos="-0.5 0.5 -1" />
                            <Vertex pos="-0.5 -0.5 3" />
                            <Vertex pos="-0.5 -0.5 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="164" owner="0" type="0" pos="36.5 -3.5 6.5" rot="1 0 0 0" scale="" transform="1 0 0 36.5 0 1 0 -3.5 0 0 1 6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 3" />
                            <Vertex pos="0.5 0.5 -1" />
                            <Vertex pos="0.5 -0.5 3" />
                            <Vertex pos="0.5 -0.5 -1" />
                            <Vertex pos="-0.5 0.5 3" />
                            <Vertex pos="-0.5 0.5 -1" />
                            <Vertex pos="-0.5 -0.5 3" />
                            <Vertex pos="-0.5 -0.5 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="165" owner="0" type="0" pos="36.5 0 10" rot="1 0 0 0" scale="" transform="1 0 0 36.5 0 1 0 0 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 3 0.5" />
                            <Vertex pos="0.5 3 -0.5" />
                            <Vertex pos="0.5 -3 0.5" />
                            <Vertex pos="0.5 -3 -0.5" />
                            <Vertex pos="-0.5 3 0.5" />
                            <Vertex pos="-0.5 3 -0.5" />
                            <Vertex pos="-0.5 -3 0.5" />
                            <Vertex pos="-0.5 -3 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="166" owner="0" type="0" pos="27.5 0 5" rot="1 0 0 0" scale="" transform="1 0 0 27.5 0 1 0 0 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 3 0.5" />
                            <Vertex pos="0.5 3 -0.5" />
                            <Vertex pos="0.5 -3 0.5" />
                            <Vertex pos="0.5 -3 -0.5" />
                            <Vertex pos="-0.5 3 0.5" />
                            <Vertex pos="-0.5 3 -0.5" />
                            <Vertex pos="-0.5 -3 0.5" />
                            <Vertex pos="-0.5 -3 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="167" owner="0" type="0" pos="27.5 0 10" rot="1 0 0 0" scale="" transform="1 0 0 27.5 0 1 0 0 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 3 0.5" />
                            <Vertex pos="0.5 3 -0.5" />
                            <Vertex pos="0.5 -3 0.5" />
                            <Vertex pos="0.5 -3 -0.5" />
                            <Vertex pos="-0.5 3 0.5" />
                            <Vertex pos="-0.5 3 -0.5" />
                            <Vertex pos="-0.5 -3 0.5" />
                            <Vertex pos="-0.5 -3 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="168" owner="0" type="0" pos="14.5 0 5" rot="1 0 0 0" scale="" transform="1 0 0 14.5 0 1 0 0 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 3 0.5" />
                            <Vertex pos="0.5 3 -0.5" />
                            <Vertex pos="0.5 -3 0.5" />
                            <Vertex pos="0.5 -3 -0.5" />
                            <Vertex pos="-0.5 3 0.5" />
                            <Vertex pos="-0.5 3 -0.5" />
                            <Vertex pos="-0.5 -3 0.5" />
                            <Vertex pos="-0.5 -3 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="169" owner="0" type="0" pos="14.5 0 12" rot="1 0 0 0" scale="" transform="1 0 0 14.5 0 1 0 0 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 3 0.5" />
                            <Vertex pos="0.5 3 -0.5" />
                            <Vertex pos="0.5 -3 0.5" />
                            <Vertex pos="0.5 -3 -0.5" />
                            <Vertex pos="-0.5 3 0.5" />
                            <Vertex pos="-0.5 3 -0.5" />
                            <Vertex pos="-0.5 -3 0.5" />
                            <Vertex pos="-0.5 -3 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="170" owner="0" type="0" pos="-16.5 0 5" rot="1 0 0 0" scale="" transform="1 0 0 -16.5 0 1 0 0 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 3 0.5" />
                            <Vertex pos="0.5 3 -0.5" />
                            <Vertex pos="0.5 -3 0.5" />
                            <Vertex pos="0.5 -3 -0.5" />
                            <Vertex pos="-0.5 3 0.5" />
                            <Vertex pos="-0.5 3 -0.5" />
                            <Vertex pos="-0.5 -3 0.5" />
                            <Vertex pos="-0.5 -3 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="171" owner="0" type="0" pos="-16.5 0 12" rot="1 0 0 0" scale="" transform="1 0 0 -16.5 0 1 0 0 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 3 0.5" />
                            <Vertex pos="0.5 3 -0.5" />
                            <Vertex pos="0.5 -3 0.5" />
                            <Vertex pos="0.5 -3 -0.5" />
                            <Vertex pos="-0.5 3 0.5" />
                            <Vertex pos="-0.5 3 -0.5" />
                            <Vertex pos="-0.5 -3 0.5" />
                            <Vertex pos="-0.5 -3 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="172" owner="0" type="0" pos="-23.5 0 5" rot="1 0 0 0" scale="" transform="1 0 0 -23.5 0 1 0 0 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 3 0.5" />
                            <Vertex pos="0.5 3 -0.5" />
                            <Vertex pos="0.5 -3 0.5" />
                            <Vertex pos="0.5 -3 -0.5" />
                            <Vertex pos="-0.5 3 0.5" />
                            <Vertex pos="-0.5 3 -0.5" />
                            <Vertex pos="-0.5 -3 0.5" />
                            <Vertex pos="-0.5 -3 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="173" owner="0" type="0" pos="-23.5 0 10" rot="1 0 0 0" scale="" transform="1 0 0 -23.5 0 1 0 0 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 3 0.5" />
                            <Vertex pos="0.5 3 -0.5" />
                            <Vertex pos="0.5 -3 0.5" />
                            <Vertex pos="0.5 -3 -0.5" />
                            <Vertex pos="-0.5 3 0.5" />
                            <Vertex pos="-0.5 3 -0.5" />
                            <Vertex pos="-0.5 -3 0.5" />
                            <Vertex pos="-0.5 -3 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="174" owner="0" type="0" pos="-34.5 0 5" rot="1 0 0 0" scale="" transform="1 0 0 -34.5 0 1 0 0 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 3 0.5" />
                            <Vertex pos="0.5 3 -0.5" />
                            <Vertex pos="0.5 -3 0.5" />
                            <Vertex pos="0.5 -3 -0.5" />
                            <Vertex pos="-0.5 3 0.5" />
                            <Vertex pos="-0.5 3 -0.5" />
                            <Vertex pos="-0.5 -3 0.5" />
                            <Vertex pos="-0.5 -3 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="175" owner="0" type="0" pos="-34.5 0 10" rot="1 0 0 0" scale="" transform="1 0 0 -34.5 0 1 0 0 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 3 0.5" />
                            <Vertex pos="0.5 3 -0.5" />
                            <Vertex pos="0.5 -3 0.5" />
                            <Vertex pos="0.5 -3 -0.5" />
                            <Vertex pos="-0.5 3 0.5" />
                            <Vertex pos="-0.5 3 -0.5" />
                            <Vertex pos="-0.5 -3 0.5" />
                            <Vertex pos="-0.5 -3 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="176" owner="0" type="0" pos="-41.5 0 5" rot="1 0 0 0" scale="" transform="1 0 0 -41.5 0 1 0 0 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 3 0.5" />
                            <Vertex pos="0.5 3 -0.5" />
                            <Vertex pos="0.5 -3 0.5" />
                            <Vertex pos="0.5 -3 -0.5" />
                            <Vertex pos="-0.5 3 0.5" />
                            <Vertex pos="-0.5 3 -0.5" />
                            <Vertex pos="-0.5 -3 0.5" />
                            <Vertex pos="-0.5 -3 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="177" owner="0" type="0" pos="-41.5 0 8" rot="1 0 0 0" scale="" transform="1 0 0 -41.5 0 1 0 0 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 3 0.5" />
                            <Vertex pos="0.5 3 -0.5" />
                            <Vertex pos="0.5 -3 0.5" />
                            <Vertex pos="0.5 -3 -0.5" />
                            <Vertex pos="-0.5 3 0.5" />
                            <Vertex pos="-0.5 3 -0.5" />
                            <Vertex pos="-0.5 -3 0.5" />
                            <Vertex pos="-0.5 -3 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="178" owner="0" type="0" pos="-52.5 0 5" rot="1 0 0 0" scale="" transform="1 0 0 -52.5 0 1 0 0 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 3 0.5" />
                            <Vertex pos="0.5 3 -0.5" />
                            <Vertex pos="0.5 1.5 0.5" />
                            <Vertex pos="0.5 1.5 -0.5" />
                            <Vertex pos="-0.5 3 0.5" />
                            <Vertex pos="-0.5 3 -0.5" />
                            <Vertex pos="-0.5 1.5 0.5" />
                            <Vertex pos="-0.5 1.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 1.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="179" owner="0" type="0" pos="-52.5 0 8" rot="1 0 0 0" scale="" transform="1 0 0 -52.5 0 1 0 0 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 3 0.5" />
                            <Vertex pos="0.5 3 -0.5" />
                            <Vertex pos="0.5 -3 0.5" />
                            <Vertex pos="0.5 -3 -0.5" />
                            <Vertex pos="-0.5 3 0.5" />
                            <Vertex pos="-0.5 3 -0.5" />
                            <Vertex pos="-0.5 -3 0.5" />
                            <Vertex pos="-0.5 -3 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="180" owner="0" type="0" pos="-52.5 -5 5" rot="1 0 0 0" scale="" transform="1 0 0 -52.5 0 1 0 -5 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 3.5 0.5" />
                            <Vertex pos="0.5 3.5 -0.5" />
                            <Vertex pos="0.5 2 0.5" />
                            <Vertex pos="0.5 2 -0.5" />
                            <Vertex pos="-0.5 3.5 0.5" />
                            <Vertex pos="-0.5 3.5 -0.5" />
                            <Vertex pos="-0.5 2 0.5" />
                            <Vertex pos="-0.5 2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 768 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 2" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="183" owner="0" type="0" pos="-47 -3.5 7" rot="1 0 0 0" scale="" transform="1 0 0 -47 0 1 0 -3.5 0 0 1 7 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.5 0.5" />
                            <Vertex pos="5 0.5 -0.5" />
                            <Vertex pos="5 -0.5 0.5" />
                            <Vertex pos="5 -0.5 -0.5" />
                            <Vertex pos="-5 0.5 -0.5" />
                            <Vertex pos="-5 0.5 -1.5" />
                            <Vertex pos="-5 -0.5 -0.5" />
                            <Vertex pos="-5 -0.5 -1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0.099998 0.0025177 0.0999993 0 -1 -1061.12 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0.1 0.000228882 0.100001 0 -1 1292.8 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.0995037 0 0.995037 -0" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.0995037 0 -0.995037 -0.995037" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="184" owner="0" type="0" pos="-47 3.5 7" rot="1 0 0 0" scale="" transform="1 0 0 -47 0 1 0 3.5 0 0 1 7 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.5 0.5" />
                            <Vertex pos="5 0.5 -0.5" />
                            <Vertex pos="5 -0.5 0.5" />
                            <Vertex pos="5 -0.5 -0.5" />
                            <Vertex pos="-5 0.5 -0.5" />
                            <Vertex pos="-5 0.5 -1.5" />
                            <Vertex pos="-5 -0.5 -0.5" />
                            <Vertex pos="-5 -0.5 -1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0.099998 0.0025177 0.0999993 0 -1 -1061.12 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0.1 0.000228882 0.100001 0 -1 1292.8 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.0995037 0 0.995037 -0" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.0995037 0 -0.995037 -0.995037" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="185" owner="0" type="0" pos="-36 -3.5 8" rot="1 0 0 0" scale="" transform="1 0 0 -36 0 1 0 -3.5 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.5 -1.5" />
                            <Vertex pos="1 0.5 -2.5" />
                            <Vertex pos="1 -0.5 -1.5" />
                            <Vertex pos="1 -0.5 -2.5" />
                            <Vertex pos="-5 0.5 -0.5" />
                            <Vertex pos="-5 0.5 -1.5" />
                            <Vertex pos="-5 -0.5 -0.5" />
                            <Vertex pos="-5 -0.5 -1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0.166667 597.334 0.166667 0 1 1258.67 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 -0.166667 -341.333 -0.166667 0 -1 362.667 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.164399 0 0.986394 1.31519" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.164399 0 -0.986394 -2.30159" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="186" owner="0" type="0" pos="-36 3.5 8" rot="1 0 0 0" scale="" transform="1 0 0 -36 0 1 0 3.5 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.5 -1.5" />
                            <Vertex pos="1 0.5 -2.5" />
                            <Vertex pos="1 -0.5 -1.5" />
                            <Vertex pos="1 -0.5 -2.5" />
                            <Vertex pos="-5 0.5 -0.5" />
                            <Vertex pos="-5 0.5 -1.5" />
                            <Vertex pos="-5 -0.5 -0.5" />
                            <Vertex pos="-5 -0.5 -1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0.166667 597.334 0.166667 0 1 1258.67 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 -0.166667 -341.333 -0.166667 0 -1 362.667 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.164399 0 0.986394 1.31519" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.164399 0 -0.986394 -2.30159" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="187" owner="0" type="0" pos="-29 -3.5 7" rot="1 0 0 0" scale="" transform="1 0 0 -29 0 1 0 -3.5 0 0 1 7 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.5 2.5" />
                            <Vertex pos="5 0.5 1.5" />
                            <Vertex pos="5 -0.5 2.5" />
                            <Vertex pos="5 -0.5 1.5" />
                            <Vertex pos="-5 0.5 -0.5" />
                            <Vertex pos="-5 0.5 -1.5" />
                            <Vertex pos="-5 -0.5 -0.5" />
                            <Vertex pos="-5 -0.5 -1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 -0.3 0.000274658 -0.3 0 1 1395.2 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0.3 256 0.3 0 -1 1472 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.287348 0 0.957826 -0.957826" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.287348 0 -0.957826 -0" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="188" owner="0" type="0" pos="-29 3.5 7" rot="1 0 0 0" scale="" transform="1 0 0 -29 0 1 0 3.5 0 0 1 7 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.5 2.5" />
                            <Vertex pos="5 0.5 1.5" />
                            <Vertex pos="5 -0.5 2.5" />
                            <Vertex pos="5 -0.5 1.5" />
                            <Vertex pos="-5 0.5 -0.5" />
                            <Vertex pos="-5 0.5 -1.5" />
                            <Vertex pos="-5 -0.5 -0.5" />
                            <Vertex pos="-5 -0.5 -1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 -0.3 0.000274658 -0.3 0 1 1395.2 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0.3 256 0.3 0 -1 1472 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.287348 0 0.957826 -0.957826" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.287348 0 -0.957826 -0" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="189" owner="0" type="0" pos="-36 -3.5 12" rot="1 0 0 0" scale="" transform="1 0 0 -36 0 1 0 -3.5 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.5 -1.5" />
                            <Vertex pos="1 0.5 -2.5" />
                            <Vertex pos="1 -0.5 -1.5" />
                            <Vertex pos="1 -0.5 -2.5" />
                            <Vertex pos="-5 0.5 -3.5" />
                            <Vertex pos="-5 0.5 -4.5" />
                            <Vertex pos="-5 -0.5 -3.5" />
                            <Vertex pos="-5 -0.5 -4.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 -0.333333 725.334 -0.333333 0 1 1664 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0.333333 -469.333 0.333333 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.316228 0 0.948683 1.73925" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.316228 0 -0.948683 -2.68794" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="190" owner="0" type="0" pos="-36 3.5 12" rot="1 0 0 0" scale="" transform="1 0 0 -36 0 1 0 3.5 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.5 -1.5" />
                            <Vertex pos="1 0.5 -2.5" />
                            <Vertex pos="1 -0.5 -1.5" />
                            <Vertex pos="1 -0.5 -2.5" />
                            <Vertex pos="-5 0.5 -3.5" />
                            <Vertex pos="-5 0.5 -4.5" />
                            <Vertex pos="-5 -0.5 -3.5" />
                            <Vertex pos="-5 -0.5 -4.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 -0.333333 725.334 -0.333333 0 1 1664 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0.333333 -469.333 0.333333 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.316228 0 0.948683 1.73925" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.316228 0 -0.948683 -2.68794" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="191" owner="0" type="0" pos="-18 -3.5 14" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 -3.5 0 0 1 14 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.5 -1.5" />
                            <Vertex pos="1 0.5 -2.5" />
                            <Vertex pos="1 -0.5 -1.5" />
                            <Vertex pos="1 -0.5 -2.5" />
                            <Vertex pos="-5 0.5 -3.5" />
                            <Vertex pos="-5 0.5 -4.5" />
                            <Vertex pos="-5 -0.5 -3.5" />
                            <Vertex pos="-5 -0.5 -4.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 -0.333333 725.334 -0.333333 0 1 1664 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0.333333 -469.333 0.333333 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.316228 0 0.948683 1.73925" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.316228 0 -0.948683 -2.68794" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="192" owner="0" type="0" pos="-18 3.5 14" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 3.5 0 0 1 14 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.5 -1.5" />
                            <Vertex pos="1 0.5 -2.5" />
                            <Vertex pos="1 -0.5 -1.5" />
                            <Vertex pos="1 -0.5 -2.5" />
                            <Vertex pos="-5 0.5 -3.5" />
                            <Vertex pos="-5 0.5 -4.5" />
                            <Vertex pos="-5 -0.5 -3.5" />
                            <Vertex pos="-5 -0.5 -4.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 -0.333333 725.334 -0.333333 0 1 1664 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0.333333 -469.333 0.333333 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.316228 0 0.948683 1.73925" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.316228 0 -0.948683 -2.68794" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="193" owner="0" type="0" pos="-18 -3.5 10" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 -3.5 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.5 -3.5" />
                            <Vertex pos="1 0.5 -4.5" />
                            <Vertex pos="1 -0.5 -3.5" />
                            <Vertex pos="1 -0.5 -4.5" />
                            <Vertex pos="-5 0.5 -0.5" />
                            <Vertex pos="-5 0.5 -1.5" />
                            <Vertex pos="-5 -0.5 -0.5" />
                            <Vertex pos="-5 -0.5 -1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0.5 1024 0.5 0 1 1216 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 -0.5 -768 -0.5 0 -1 832 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.447214 0 0.894427 2.68328" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.447214 0 -0.894427 -3.57771" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="194" owner="0" type="0" pos="-18 3.5 10" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 3.5 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.5 -3.5" />
                            <Vertex pos="1 0.5 -4.5" />
                            <Vertex pos="1 -0.5 -3.5" />
                            <Vertex pos="1 -0.5 -4.5" />
                            <Vertex pos="-5 0.5 -0.5" />
                            <Vertex pos="-5 0.5 -1.5" />
                            <Vertex pos="-5 -0.5 -0.5" />
                            <Vertex pos="-5 -0.5 -1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0.5 1024 0.5 0 1 1216 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 -0.5 -768 -0.5 0 -1 832 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.447214 0 0.894427 2.68328" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.447214 0 -0.894427 -3.57771" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="195" owner="0" type="0" pos="-11 -3.5 7" rot="1 0 0 0" scale="" transform="1 0 0 -11 0 1 0 -3.5 0 0 1 7 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="7 0.5 4.5" />
                            <Vertex pos="7 0.5 3.5" />
                            <Vertex pos="7 -0.5 4.5" />
                            <Vertex pos="7 -0.5 3.5" />
                            <Vertex pos="-5 0.5 -0.5" />
                            <Vertex pos="-5 0.5 -1.5" />
                            <Vertex pos="-5 -0.5 -0.5" />
                            <Vertex pos="-5 -0.5 -1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -7" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 -0.416667 -149.332 -0.416668 0 1 1440 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0.416667 405.333 0.416667 0 -1 2272 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.384615 0 0.923077 -1.46154" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.384615 0 -0.923077 0.538462" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="196" owner="0" type="0" pos="-11 3.5 7" rot="1 0 0 0" scale="" transform="1 0 0 -11 0 1 0 3.5 0 0 1 7 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="7 0.5 4.5" />
                            <Vertex pos="7 0.5 3.5" />
                            <Vertex pos="7 -0.5 4.5" />
                            <Vertex pos="7 -0.5 3.5" />
                            <Vertex pos="-5 0.5 -0.5" />
                            <Vertex pos="-5 0.5 -1.5" />
                            <Vertex pos="-5 -0.5 -0.5" />
                            <Vertex pos="-5 -0.5 -1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -7" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 -0.416667 -149.332 -0.416668 0 1 1440 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0.416667 405.333 0.416667 0 -1 2272 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.384615 0 0.923077 -1.46154" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.384615 0 -0.923077 0.538462" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="197" owner="0" type="0" pos="13 -3.5 10" rot="1 0 0 0" scale="" transform="1 0 0 13 0 1 0 -3.5 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.5 -3.5" />
                            <Vertex pos="1 0.5 -4.5" />
                            <Vertex pos="1 -0.5 -3.5" />
                            <Vertex pos="1 -0.5 -4.5" />
                            <Vertex pos="-7 0.5 1.5" />
                            <Vertex pos="-7 0.5 0.5" />
                            <Vertex pos="-7 -0.5 1.5" />
                            <Vertex pos="-7 -0.5 0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -7" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0.625 992 0.625 0 1 2032 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 -0.625 -736 -0.625 0 -1 976 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.529999 0 0.847998 2.438" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.529999 0 -0.847998 -3.28599" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="198" owner="0" type="0" pos="13 3.5 10" rot="1 0 0 0" scale="" transform="1 0 0 13 0 1 0 3.5 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.5 -3.5" />
                            <Vertex pos="1 0.5 -4.5" />
                            <Vertex pos="1 -0.5 -3.5" />
                            <Vertex pos="1 -0.5 -4.5" />
                            <Vertex pos="-7 0.5 1.5" />
                            <Vertex pos="-7 0.5 0.5" />
                            <Vertex pos="-7 -0.5 1.5" />
                            <Vertex pos="-7 -0.5 0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -7" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0.625 992 0.625 0 1 2032 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 -0.625 -736 -0.625 0 -1 976 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.529999 0 0.847998 2.438" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.529999 0 -0.847998 -3.28599" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="199" owner="0" type="0" pos="22 -3.5 11" rot="1 0 0 0" scale="" transform="1 0 0 22 0 1 0 -3.5 0 0 1 11 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.5 -0.5" />
                            <Vertex pos="5 0.5 -1.5" />
                            <Vertex pos="5 -0.5 -0.5" />
                            <Vertex pos="5 -0.5 -1.5" />
                            <Vertex pos="-7 0.5 1.5" />
                            <Vertex pos="-7 0.5 0.5" />
                            <Vertex pos="-7 -0.5 1.5" />
                            <Vertex pos="-7 -0.5 0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -7" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0.166666 170.667 0.166668 0 1 1856 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 -0.166666 85.3343 -0.166668 0 -1 1344 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.164399 0 0.986394 -0.328798" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.164399 0 -0.986394 -0.657596" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="200" owner="0" type="0" pos="22 3.5 11" rot="1 0 0 0" scale="" transform="1 0 0 22 0 1 0 3.5 0 0 1 11 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.5 -0.5" />
                            <Vertex pos="5 0.5 -1.5" />
                            <Vertex pos="5 -0.5 -0.5" />
                            <Vertex pos="5 -0.5 -1.5" />
                            <Vertex pos="-7 0.5 1.5" />
                            <Vertex pos="-7 0.5 0.5" />
                            <Vertex pos="-7 -0.5 1.5" />
                            <Vertex pos="-7 -0.5 0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -7" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0.166666 170.667 0.166668 0 1 1856 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 -0.166666 85.3343 -0.166668 0 -1 1344 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.164399 0 0.986394 -0.328798" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.164399 0 -0.986394 -0.657596" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="201" owner="0" type="0" pos="20 -3.5 7" rot="1 0 0 0" scale="" transform="1 0 0 20 0 1 0 -3.5 0 0 1 7 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="7 0.5 2.5" />
                            <Vertex pos="7 0.5 1.5" />
                            <Vertex pos="7 -0.5 2.5" />
                            <Vertex pos="7 -0.5 1.5" />
                            <Vertex pos="-5 0.5 -0.5" />
                            <Vertex pos="-5 0.5 -1.5" />
                            <Vertex pos="-5 -0.5 -0.5" />
                            <Vertex pos="-5 -0.5 -1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -7" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 -0.25 64.0002 -0.25 0 1 1376 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0.25 192 0.25 0 -1 1952 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970142 -0.727607" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970142 -0.242536" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="202" owner="0" type="0" pos="20 3.5 7" rot="1 0 0 0" scale="" transform="1 0 0 20 0 1 0 3.5 0 0 1 7 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="7 0.5 2.5" />
                            <Vertex pos="7 0.5 1.5" />
                            <Vertex pos="7 -0.5 2.5" />
                            <Vertex pos="7 -0.5 1.5" />
                            <Vertex pos="-5 0.5 -0.5" />
                            <Vertex pos="-5 0.5 -1.5" />
                            <Vertex pos="-5 -0.5 -0.5" />
                            <Vertex pos="-5 -0.5 -1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -7" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 -0.25 64.0002 -0.25 0 1 1376 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 0.25 192 0.25 0 -1 1952 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970142 -0.727607" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970142 -0.242536" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="203" owner="0" type="0" pos="35 -3.5 10" rot="1 0 0 0" scale="" transform="1 0 0 35 0 1 0 -3.5 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.5 -3.5" />
                            <Vertex pos="1 0.5 -4.5" />
                            <Vertex pos="1 -0.5 -3.5" />
                            <Vertex pos="1 -0.5 -4.5" />
                            <Vertex pos="-7 0.5 -0.5" />
                            <Vertex pos="-7 0.5 -1.5" />
                            <Vertex pos="-7 -0.5 -0.5" />
                            <Vertex pos="-7 -0.5 -1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -7" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0.374998 1056 0.374999 0 1 1744 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 -0.375 -800 -0.374999 0 -1 687.999 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.351123 0 0.936329 2.92603" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.351123 0 -0.936329 -3.86236" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="204" owner="0" type="0" pos="35 3.5 10" rot="1 0 0 0" scale="" transform="1 0 0 35 0 1 0 3.5 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.5 -3.5" />
                            <Vertex pos="1 0.5 -4.5" />
                            <Vertex pos="1 -0.5 -3.5" />
                            <Vertex pos="1 -0.5 -4.5" />
                            <Vertex pos="-7 0.5 -0.5" />
                            <Vertex pos="-7 0.5 -1.5" />
                            <Vertex pos="-7 -0.5 -0.5" />
                            <Vertex pos="-7 -0.5 -1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -7" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 0.374998 1056 0.374999 0 1 1744 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 -0.375 -800 -0.374999 0 -1 687.999 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.351123 0 0.936329 2.92603" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.351123 0 -0.936329 -3.86236" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="205" owner="0" type="0" pos="4 -3.5 25" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 -3.5 0 0 1 25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.5 -3.5" />
                            <Vertex pos="1 0.5 -4.5" />
                            <Vertex pos="1 -0.5 -3.5" />
                            <Vertex pos="1 -0.5 -4.5" />
                            <Vertex pos="-2.5 0.5 0.5" />
                            <Vertex pos="-2.5 0.5 -0.5" />
                            <Vertex pos="-2.5 -0.5 0.5" />
                            <Vertex pos="-2.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-0.999999 0 1.14286 859.431 1.14286 0 1 786.286 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0.999999 0 -1.14286 -603.427 -1.14286 0 -1 1572.58 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.752577 0 0.658505 1.55219" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.752577 0 -0.658505 -2.21069" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="206" owner="0" type="0" pos="4 3.5 25" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 3.5 0 0 1 25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.5 -3.5" />
                            <Vertex pos="1 0.5 -4.5" />
                            <Vertex pos="1 -0.5 -3.5" />
                            <Vertex pos="1 -0.5 -4.5" />
                            <Vertex pos="-2.5 0.5 0.5" />
                            <Vertex pos="-2.5 0.5 -0.5" />
                            <Vertex pos="-2.5 -0.5 0.5" />
                            <Vertex pos="-2.5 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-0.999999 0 1.14286 859.431 1.14286 0 1 786.286 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="0.999999 0 -1.14286 -603.427 -1.14286 0 -1 1572.58 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.752577 0 0.658505 1.55219" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.752577 0 -0.658505 -2.21069" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="207" owner="0" type="0" pos="-0.5 -3.5 29" rot="1 0 0 0" scale="" transform="1 0 0 -0.5 0 1 0 -3.5 0 0 1 29 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.5 -3.5" />
                            <Vertex pos="1 0.5 -4.5" />
                            <Vertex pos="1 -0.5 -3.5" />
                            <Vertex pos="1 -0.5 -4.5" />
                            <Vertex pos="-2.5 0.5 -7.5" />
                            <Vertex pos="-2.5 0.5 -8.5" />
                            <Vertex pos="-2.5 -0.5 -7.5" />
                            <Vertex pos="-2.5 -0.5 -8.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 -1.14286 1444.57 -1.14286 0 1 3126.86 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 1.14286 -1188.57 1.14286 0 -1 -768.002 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.752577 0 0.658505 3.05734" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.752577 0 -0.658505 -3.71585" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="208" owner="0" type="0" pos="-0.5 3.5 29" rot="1 0 0 0" scale="" transform="1 0 0 -0.5 0 1 0 3.5 0 0 1 29 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.5 -3.5" />
                            <Vertex pos="1 0.5 -4.5" />
                            <Vertex pos="1 -0.5 -3.5" />
                            <Vertex pos="1 -0.5 -4.5" />
                            <Vertex pos="-2.5 0.5 -7.5" />
                            <Vertex pos="-2.5 0.5 -8.5" />
                            <Vertex pos="-2.5 -0.5 -7.5" />
                            <Vertex pos="-2.5 -0.5 -8.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_beam_metal" texgens="0 1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.5" album="Blasted" material="bm_beam_metal" texgens="0 -1 0 128 0 0 -1 128 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_beam_metal" texgens="-1 0 -1.14286 1444.57 -1.14286 0 1 3126.86 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_beam_metal" texgens="1 0 1.14286 -1188.57 1.14286 0 -1 -768.002 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.752577 0 0.658505 3.05734" album="Blasted" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.752577 0 -0.658505 -3.71585" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 1280 90 0.125 0.125" texRot="90" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="209" owner="0" type="0" pos="3 -0.520945 0" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 -0.520945 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="3 0.520945 0.5" />
                            <Vertex pos="2.90885 -0.520945 0.5" />
                            <Vertex pos="-3 0.520945 0.5" />
                            <Vertex pos="3 0.520945 -0.5" />
                            <Vertex pos="2.90885 -0.520945 -0.5" />
                            <Vertex pos="-3 0.520945 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.5" album="Blasted" material="bm_wood" texgens="1 0 0 768 0 -1 0 133.362 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 -768 0 -1 0 133.362 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.996195 -0.0871524 0 -2.94318" album="Blasted" material="bm_beam" texgens="0 0 -1 128 -0.0871522 -0.996195 0 191.025 0 0.125 0.130734" texRot="0" texScale="0.125 0.130734" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0 1 -0 -0.520945" album="Blasted" material="bm_wood" texgens="0 0 -1 0 1 0 0 96 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.173648 -0.984808 -0 -0.00791407" album="Blasted" material="bm_wood" texgens="0 0 -1 0 1 0 0 96 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="210" owner="0" type="0" pos="2.95443 -1.02606 0" rot="1 0 0 0" scale="" transform="1 0 0 2.95443 0 1 0 -1.02606 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="2.95443 -0.0158299 0.5" />
                            <Vertex pos="2.68374 -1.02606 0.5" />
                            <Vertex pos="-2.95443 1.02606 0.5" />
                            <Vertex pos="2.95443 -0.0158299 -0.5" />
                            <Vertex pos="2.68374 -1.02606 -0.5" />
                            <Vertex pos="-2.95443 1.02606 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.5" album="Blasted" material="bm_wood" texgens="1 0 0 756.334 0 -1 0 262.671 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 -756.334 0 -1 0 262.671 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.965926 -0.258819 0 -2.85786" album="Blasted" material="bm_beam" texgens="0 0 -1 128 -0.258819 -0.965926 0 183.426 0 0.125 0.130733" texRot="0" texScale="0.125 0.130733" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.173648 0.984808 -0 -0.497441" album="Blasted" material="bm_wood" texgens="0 0 -1 0 0.984808 -0.173648 0 98.807 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.342019 -0.939693 -0 -0.0462906" album="Blasted" material="bm_wood" texgens="0 0 -1 0 0.984808 -0.173648 0 98.807 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="211" owner="0" type="0" pos="2.81908 -1.5 -2.98023e-008" rot="1 0 0 0" scale="" transform="1 0 0 2.81908 0 1 0 -1.5 0 0 1 -2.98023e-008 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="2.81908 -0.55212 0.5" />
                            <Vertex pos="2.37707 -1.5 0.5" />
                            <Vertex pos="-2.81908 1.5 0.5" />
                            <Vertex pos="2.81908 -0.55212 -0.5" />
                            <Vertex pos="2.37707 -1.5 -0.5" />
                            <Vertex pos="-2.81908 1.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.5" album="Blasted" material="bm_wood" texgens="1 0 0 721.685 0 -1 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 -721.685 0 -1 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.906305 -0.422623 0 -2.78829" album="Blasted" material="bm_beam" texgens="0 0 -1 128 -0.422623 -0.906305 0 169.142 0 0.125 0.130734" texRot="0" texScale="0.125 0.130734" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.34202 0.939693 -0 -0.445358" album="Blasted" material="bm_wood" texgens="0 0 -1 0 0.939693 -0.34202 0 101.187 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.5 -0.866025 -0 -0.110503" album="Blasted" material="bm_wood" texgens="0 0 -1 0 0.939693 -0.34202 0 101.187 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="212" owner="0" type="0" pos="2.59808 -1.92837 0" rot="1 0 0 0" scale="" transform="1 0 0 2.59808 0 1 0 -1.92837 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="2.59808 -1.07164 0.5" />
                            <Vertex pos="1.9982 -1.92837 0.5" />
                            <Vertex pos="-2.59808 1.92837 0.5" />
                            <Vertex pos="2.59808 -1.07164 -0.5" />
                            <Vertex pos="1.9982 -1.92837 -0.5" />
                            <Vertex pos="-2.59808 1.92837 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.5" album="Blasted" material="bm_wood" texgens="1 0 0 665.108 0 -1 0 493.663 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 -665.108 0 -1 0 493.663 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.819156 -0.573571 0 -2.74289" album="Blasted" material="bm_beam" texgens="0 0 -1 128 -0.573571 -0.819156 0 149.885 0 0.125 0.130734" texRot="0" texScale="0.125 0.130734" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.500001 0.866025 -0 -0.370975" album="Blasted" material="bm_wood" texgens="0 0 -1 0 0.866025 -0.5 0 102.854 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.642788 -0.766044 -0 -0.192798" album="Blasted" material="bm_wood" texgens="0 0 -1 0 0.866025 -0.5 0 102.854 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="213" owner="0" type="0" pos="2.29814 -2.29814 0" rot="1 0 0 0" scale="" transform="1 0 0 2.29814 0 1 0 -2.29814 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="2.29814 -1.55859 0.5" />
                            <Vertex pos="1.55858 -2.29814 0.5" />
                            <Vertex pos="-2.29814 2.29814 0.5" />
                            <Vertex pos="2.29814 -1.55859 -0.5" />
                            <Vertex pos="1.55858 -2.29814 -0.5" />
                            <Vertex pos="-2.29814 2.29814 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.5" album="Blasted" material="bm_wood" texgens="1 0 0 588.324 0 -1 0 588.324 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 -588.324 0 -1 0 588.324 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.707102 -0.707112 0 -2.72712" album="Blasted" material="bm_beam" texgens="0 0 -1 128 -0.707112 -0.707102 0 128.004 0 0.125 0.130734" texRot="0" texScale="0.125 0.130734" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.642787 0.766045 -0 -0.283264" album="Blasted" material="bm_wood" texgens="0 0 -1 0 0.766044 -0.642788 0 103.606 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.766046 -0.642786 -0 -0.283268" album="Blasted" material="bm_wood" texgens="0 0 -1 0 0.766044 -0.642788 0 103.606 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="214" owner="0" type="0" pos="1.92836 -2.59808 0" rot="1 0 0 0" scale="" transform="1 0 0 1.92836 0 1 0 -2.59808 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1.92836 -1.99819 0.5" />
                            <Vertex pos="1.07163 -2.59808 0.5" />
                            <Vertex pos="-1.92836 2.59808 0.5" />
                            <Vertex pos="1.92836 -1.99819 -0.5" />
                            <Vertex pos="1.07163 -2.59808 -0.5" />
                            <Vertex pos="-1.92836 2.59808 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.5" album="Blasted" material="bm_wood" texgens="1 0 0 493.66 0 -1 0 665.108 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 -493.66 0 -1 0 665.108 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.573577 -0.819152 0 -2.74288" album="Blasted" material="bm_beam" texgens="0 0 -1 128 -0.819151 -0.573577 0 106.109 0 0.125 0.130734" texRot="0" texScale="0.125 0.130734" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.766045 0.642787 -0 -0.192801" album="Blasted" material="bm_wood" texgens="0 0 -1 0 0.642787 -0.766045 0 103.353 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.866026 -0.499998 -0 -0.370975" album="Blasted" material="bm_wood" texgens="0 0 -1 0 0.642787 -0.766045 0 103.353 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="215" owner="0" type="0" pos="1.49999 -2.81907 0" rot="1 0 0 0" scale="" transform="1 0 0 1.49999 0 1 0 -2.81907 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1.49999 -2.37709 0.5" />
                            <Vertex pos="0.552125 -2.81908 0.5" />
                            <Vertex pos="-1.49999 2.81908 0.5" />
                            <Vertex pos="1.49999 -2.37709 -0.5" />
                            <Vertex pos="0.552125 -2.81908 -0.5" />
                            <Vertex pos="-1.49999 2.81908 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.5" album="Blasted" material="bm_wood" texgens="1 0 0 383.997 0 -1 0 721.682 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 -383.997 0 -1 0 721.682 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.422613 -0.90631 0 -2.7883" album="Blasted" material="bm_beam" texgens="0 0 -1 128 -0.906311 -0.422611 0 86.8657 0 0.125 0.130732" texRot="0" texScale="0.125 0.130732" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.866028 0.499996 -0 -0.110497" album="Blasted" material="bm_wood" texgens="0 0 -1 0 0.499998 -0.866026 0 102.124 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.939693 -0.342019 -0 -0.445351" album="Blasted" material="bm_wood" texgens="0 0 -1 0 0.499998 -0.866026 0 102.124 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="216" owner="0" type="0" pos="1.02606 -2.95442 0" rot="1 0 0 0" scale="" transform="1 0 0 1.02606 0 1 0 -2.95442 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1.02606 -2.68373 0.5" />
                            <Vertex pos="0.0158499 -2.95442 0.5" />
                            <Vertex pos="-1.02606 2.95442 0.5" />
                            <Vertex pos="1.02606 -2.68373 -0.5" />
                            <Vertex pos="0.0158499 -2.95442 -0.5" />
                            <Vertex pos="-1.02606 2.95442 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.5" album="Blasted" material="bm_wood" texgens="1 0 0 262.671 0 -1 0 756.332 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 -262.671 0 -1 0 756.332 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.258824 -0.965925 0 -2.85785" album="Blasted" material="bm_beam" texgens="0 0 -1 128 -0.965925 -0.258824 0 72.5726 0 0.125 0.130731" texRot="0" texScale="0.125 0.130731" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.939692 0.34202 -0 -0.0462909" album="Blasted" material="bm_wood" texgens="0 0 -1 0 0.34202 -0.939693 0 100.07 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.984807 -0.173652 -0 -0.497431" album="Blasted" material="bm_wood" texgens="0 0 -1 0 0.34202 -0.939693 0 100.07 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="217" owner="0" type="0" pos="0.520944 -3 2.98023e-008" rot="1 0 0 0" scale="" transform="1 0 0 0.520944 0 1 0 -3 0 0 1 2.98023e-008 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.520966 -2.90884 0.5" />
                            <Vertex pos="-0.520966 -3 0.5" />
                            <Vertex pos="-0.520944 3 0.5" />
                            <Vertex pos="0.520966 -2.90884 -0.5" />
                            <Vertex pos="-0.520966 -3 -0.5" />
                            <Vertex pos="-0.520944 3 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.5" album="Blasted" material="bm_wood" texgens="1 0 0 133.362 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 -133.362 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.0871584 -0.996194 0 -2.94318" album="Blasted" material="bm_beam" texgens="0 0 -1 128 -0.996195 -0.0871582 0 64.9732 0 0.125 0.130739" texRot="0" texScale="0.125 0.130739" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.984807 0.173652 -0 -0.00792593" album="Blasted" material="bm_wood" texgens="0 0 -1 0 0.173652 -0.984807 0 97.4363 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-1 3.66569e-006 0 -0.520955" album="Blasted" material="bm_wood" texgens="0 0 -1 0 0.173652 -0.984807 0 97.4363 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="218" owner="0" type="0" pos="-0.520945 -3 0" rot="1 0 0 0" scale="" transform="1 0 0 -0.520945 0 1 0 -3 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.520923 -3 0.5" />
                            <Vertex pos="-0.520945 -2.90885 0.5" />
                            <Vertex pos="0.520945 3 0.5" />
                            <Vertex pos="0.520923 -3 -0.5" />
                            <Vertex pos="-0.520945 -2.90885 -0.5" />
                            <Vertex pos="0.520945 3 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.5" album="Blasted" material="bm_wood" texgens="1 0 0 -133.362 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 133.362 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.0871542 -0.996195 -0 -2.94318" album="Blasted" material="bm_beam" texgens="0 0 -1 128 -0.996195 0.087154 0 191.025 0 0.125 0.130731" texRot="0" texScale="0.125 0.130731" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="1 -3.66569e-006 0 -0.520934" album="Blasted" material="bm_wood" texgens="0 0 -1 0 0 -1 0 96 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.984808 0.173648 0 -0.00791407" album="Blasted" material="bm_wood" texgens="0 0 -1 0 0 -1 0 96 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="219" owner="0" type="0" pos="-1.02606 -2.95443 0" rot="1 0 0 0" scale="" transform="1 0 0 -1.02606 0 1 0 -2.95443 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.015835 -2.95443 0.5" />
                            <Vertex pos="-1.02606 -2.68374 0.5" />
                            <Vertex pos="1.02606 2.95443 0.5" />
                            <Vertex pos="-0.015835 -2.95443 -0.5" />
                            <Vertex pos="-1.02606 -2.68374 -0.5" />
                            <Vertex pos="1.02606 2.95443 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.5" album="Blasted" material="bm_wood" texgens="1 0 0 -262.671 0 -1 0 756.334 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 262.671 0 -1 0 756.334 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.25882 -0.965926 -0 -2.85786" album="Blasted" material="bm_beam" texgens="0 0 -1 128 -0.965925 0.258821 0 183.428 0 0.125 0.130732" texRot="0" texScale="0.125 0.130732" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.984808 -0.173649 0 -0.497439" album="Blasted" material="bm_wood" texgens="0 0 -1 0 -0.173648 -0.984808 0 98.807 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.939693 0.342019 0 -0.0462906" album="Blasted" material="bm_wood" texgens="0 0 -1 0 -0.173648 -0.984808 0 98.807 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="220" owner="0" type="0" pos="-1.50002 -2.81908 0" rot="1 0 0 0" scale="" transform="1 0 0 -1.50002 0 1 0 -2.81908 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.552095 -2.81908 0.5" />
                            <Vertex pos="-1.50002 -2.37706 0.5" />
                            <Vertex pos="1.50002 2.81908 0.5" />
                            <Vertex pos="-0.552095 -2.81908 -0.5" />
                            <Vertex pos="-1.50002 -2.37706 -0.5" />
                            <Vertex pos="1.50002 2.81908 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.5" album="Blasted" material="bm_wood" texgens="1 0 0 -384.005 0 -1 0 721.685 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 384.005 0 -1 0 721.685 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.422615 -0.906309 -0 -2.78828" album="Blasted" material="bm_beam" texgens="0 0 -1 128 -0.906309 0.422617 0 169.136 0 0.125 0.130739" texRot="0" texScale="0.125 0.130739" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.939693 -0.342019 0 -0.445379" album="Blasted" material="bm_wood" texgens="0 0 -1 0 -0.342018 -0.939693 0 101.187 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.866022 0.500006 0 -0.110506" album="Blasted" material="bm_wood" texgens="0 0 -1 0 -0.342018 -0.939693 0 101.187 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="221" owner="0" type="0" pos="-1.92836 -2.59807 0" rot="1 0 0 0" scale="" transform="1 0 0 -1.92836 0 1 0 -2.59807 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1.07167 -2.59807 0.5" />
                            <Vertex pos="-1.92836 -1.99819 0.5" />
                            <Vertex pos="1.92836 2.59807 0.5" />
                            <Vertex pos="-1.07167 -2.59807 -0.5" />
                            <Vertex pos="-1.92836 -1.99819 -0.5" />
                            <Vertex pos="1.92836 2.59807 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.5" album="Blasted" material="bm_wood" texgens="1 0 0 -493.66 0 -1 0 665.106 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 493.66 0 -1 0 665.106 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.573589 -0.819143 -0 -2.74289" album="Blasted" material="bm_beam" texgens="0 0 -1 128 -0.819147 0.573584 0 149.893 0 0.125 0.130731" texRot="0" texScale="0.125 0.130731" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.866023 -0.500005 0 -0.370956" album="Blasted" material="bm_wood" texgens="0 0 -1 0 -0.500005 -0.866023 0 102.854 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.766045 0.642788 0 -0.192798" album="Blasted" material="bm_wood" texgens="0 0 -1 0 -0.500005 -0.866023 0 102.854 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="222" owner="0" type="0" pos="-2.29813 -2.29813 0" rot="1 0 0 0" scale="" transform="1 0 0 -2.29813 0 1 0 -2.29813 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1.5586 -2.29813 0.5" />
                            <Vertex pos="-2.29813 -1.5586 0.5" />
                            <Vertex pos="2.29813 2.29813 0.5" />
                            <Vertex pos="-1.5586 -2.29813 -0.5" />
                            <Vertex pos="-2.29813 -1.5586 -0.5" />
                            <Vertex pos="2.29813 2.29813 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.5" album="Blasted" material="bm_wood" texgens="1 0 0 -588.321 0 -1 0 588.321 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 588.321 0 -1 0 588.321 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.707107 -0.707107 -0 -2.72712" album="Blasted" material="bm_beam" texgens="0 0 -1 128 -0.707107 0.707107 0 128 0 0.125 0.130732" texRot="0" texScale="0.125 0.130732" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.766044 -0.642789 0 -0.283256" album="Blasted" material="bm_wood" texgens="0 0 -1 0 -0.642789 -0.766044 0 103.606 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.642789 0.766044 0 -0.283256" album="Blasted" material="bm_wood" texgens="0 0 -1 0 -0.642789 -0.766044 0 103.606 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="223" owner="0" type="0" pos="-2.59807 -1.92836 0" rot="1 0 0 0" scale="" transform="1 0 0 -2.59807 0 1 0 -1.92836 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1.99819 -1.92836 0.5" />
                            <Vertex pos="-2.59807 -1.07166 0.5" />
                            <Vertex pos="2.59807 1.92836 0.5" />
                            <Vertex pos="-1.99819 -1.92836 -0.5" />
                            <Vertex pos="-2.59807 -1.07166 -0.5" />
                            <Vertex pos="2.59807 1.92836 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.5" album="Blasted" material="bm_wood" texgens="1 0 0 -665.106 0 -1 0 493.66 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 665.106 0 -1 0 493.66 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.819147 -0.573584 -0 -2.74289" album="Blasted" material="bm_beam" texgens="0 0 -1 128 -0.57358 0.81915 0 106.11 0 0.125 0.130732" texRot="0" texScale="0.125 0.130732" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.642788 -0.766045 0 -0.192798" album="Blasted" material="bm_wood" texgens="0 0 -1 0 -0.766044 -0.642789 0 103.352 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.500003 0.866023 0 -0.370961" album="Blasted" material="bm_wood" texgens="0 0 -1 0 -0.766044 -0.642789 0 103.352 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="224" owner="0" type="0" pos="-2.81908 -1.50001 0" rot="1 0 0 0" scale="" transform="1 0 0 -2.81908 0 1 0 -1.50001 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-2.37706 -1.50001 0.5" />
                            <Vertex pos="-2.81908 -0.55209 0.5" />
                            <Vertex pos="2.81908 1.50001 0.5" />
                            <Vertex pos="-2.37706 -1.50001 -0.5" />
                            <Vertex pos="-2.81908 -0.55209 -0.5" />
                            <Vertex pos="2.81908 1.50001 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.5" album="Blasted" material="bm_wood" texgens="1 0 0 -721.685 0 -1 0 384.003 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 721.685 0 -1 0 384.003 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.906309 -0.422617 -0 -2.78828" album="Blasted" material="bm_beam" texgens="0 0 -1 128 -0.422617 0.906308 0 86.8629 0 0.125 0.130739" texRot="0" texScale="0.125 0.130739" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.500003 -0.866023 0 -0.110506" album="Blasted" material="bm_wood" texgens="0 0 -1 0 -0.866024 -0.500004 0 102.125 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.342017 0.939694 0 -0.445377" album="Blasted" material="bm_wood" texgens="0 0 -1 0 -0.866024 -0.500004 0 102.125 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="225" owner="0" type="0" pos="-2.95443 -1.02605 0" rot="1 0 0 0" scale="" transform="1 0 0 -2.95443 0 1 0 -1.02605 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-2.68374 -1.02605 0.5" />
                            <Vertex pos="-2.95443 -0.0158402 0.5" />
                            <Vertex pos="2.95443 1.02605 0.5" />
                            <Vertex pos="-2.68374 -1.02605 -0.5" />
                            <Vertex pos="-2.95443 -0.0158402 -0.5" />
                            <Vertex pos="2.95443 1.02605 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.5" album="Blasted" material="bm_wood" texgens="1 0 0 -756.334 0 -1 0 262.669 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 756.334 0 -1 0 262.669 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.965925 -0.258824 -0 -2.85786" album="Blasted" material="bm_beam" texgens="0 0 -1 128 -0.258824 0.965925 0 72.5699 0 0.125 0.130731" texRot="0" texScale="0.125 0.130731" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.342016 -0.939694 0 -0.0462903" album="Blasted" material="bm_wood" texgens="0 0 -1 0 -0.939694 -0.342017 0 100.07 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.173648 0.984808 0 -0.497431" album="Blasted" material="bm_wood" texgens="0 0 -1 0 -0.939694 -0.342017 0 100.07 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="226" owner="0" type="0" pos="-3 -0.520945 0" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 -0.520945 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-2.90885 -0.520945 0.5" />
                            <Vertex pos="-3 0.52093 0.5" />
                            <Vertex pos="3 0.520945 0.5" />
                            <Vertex pos="-2.90885 -0.520945 -0.5" />
                            <Vertex pos="-3 0.52093 -0.5" />
                            <Vertex pos="3 0.520945 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.5" album="Blasted" material="bm_wood" texgens="1 0 0 -768 0 -1 0 133.362 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 768 0 -1 0 133.362 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.996195 -0.0871537 -0 -2.94318" album="Blasted" material="bm_beam" texgens="0 0 -1 128 -0.0871534 0.996195 0 64.9749 0 0.125 0.130732" texRot="0" texScale="0.125 0.130732" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.173648 -0.984808 0 -0.00791401" album="Blasted" material="bm_wood" texgens="0 0 -1 0 -0.984808 -0.173648 0 97.4363 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-2.5034e-006 1 0 -0.520938" album="Blasted" material="bm_wood" texgens="0 0 -1 0 -0.984808 -0.173648 0 97.4363 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="227" owner="0" type="0" pos="-3 0.520947 0" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 0.520947 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-3 -0.520963 0.5" />
                            <Vertex pos="-2.90884 0.520963 0.5" />
                            <Vertex pos="3 -0.520947 0.5" />
                            <Vertex pos="-3 -0.520963 -0.5" />
                            <Vertex pos="-2.90884 0.520963 -0.5" />
                            <Vertex pos="3 -0.520947 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.5" album="Blasted" material="bm_wood" texgens="1 0 0 -768 0 -1 0 -133.362 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 768 0 -1 0 -133.362 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.996194 0.0871589 0 -2.94318" album="Blasted" material="bm_beam" texgens="0 0 -1 128 0.0871588 0.996194 0 191.028 0 0.125 0.130738" texRot="0" texScale="0.125 0.130738" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="2.67228e-006 -1 0 -0.520955" album="Blasted" material="bm_wood" texgens="0 0 -1 0 -1 0 0 96 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.173652 0.984807 0 -0.00792289" album="Blasted" material="bm_wood" texgens="0 0 -1 0 -1 0 0 96 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="228" owner="0" type="0" pos="-2.95442 1.02606 0" rot="1 0 0 0" scale="" transform="1 0 0 -2.95442 0 1 0 1.02606 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-2.95442 0.0158452 0.5" />
                            <Vertex pos="-2.68373 1.02607 0.5" />
                            <Vertex pos="2.95442 -1.02607 0.5" />
                            <Vertex pos="-2.95442 0.0158452 -0.5" />
                            <Vertex pos="-2.68373 1.02607 -0.5" />
                            <Vertex pos="2.95442 -1.02607 -0.5" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.5" album="Blasted" material="bm_wood" texgens="1 0 0 -756.332 0 -1 0 -262.671 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 756.332 0 -1 0 -262.671 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.965926 0.25882 0 -2.85785" album="Blasted" material="bm_beam" texgens="0 0 -1 128 0.258821 0.965925 0 183.425 0 0.125 0.130732" texRot="0" texScale="0.125 0.130732" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.173653 -0.984807 0 -0.497438" album="Blasted" material="bm_wood" texgens="0 0 -1 0 -0.984807 0.173652 0 98.8068 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.342023 0.939691 0 -0.0462912" album="Blasted" material="bm_wood" texgens="0 0 -1 0 -0.984807 0.173652 0 98.8068 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="229" owner="0" type="0" pos="-2.81908 1.5 0" rot="1 0 0 0" scale="" transform="1 0 0 -2.81908 0 1 0 1.5 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-2.81908 0.552135 0.5" />
                            <Vertex pos="-2.37708 1.49999 0.5" />
                            <Vertex pos="2.81908 -1.49999 0.5" />
                            <Vertex pos="-2.81908 0.552135 -0.5" />
                            <Vertex pos="-2.37708 1.49999 -0.5" />
                            <Vertex pos="2.81908 -1.49999 -0.5" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.5" album="Blasted" material="bm_wood" texgens="1 0 0 -721.685 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 721.685 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.906305 0.422625 0 -2.78829" album="Blasted" material="bm_beam" texgens="0 0 -1 128 0.422615 0.906309 0 169.136 0 0.125 0.130731" texRot="0" texScale="0.125 0.130731" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.342021 -0.939692 0 -0.445346" album="Blasted" material="bm_wood" texgens="0 0 -1 0 -0.939692 0.342022 0 101.187 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.499997 0.866027 0 -0.110499" album="Blasted" material="bm_wood" texgens="0 0 -1 0 -0.939692 0.342022 0 101.187 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="230" owner="0" type="0" pos="-2.59808 1.92836 0" rot="1 0 0 0" scale="" transform="1 0 0 -2.59808 0 1 0 1.92836 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-2.59808 1.07164 0.5" />
                            <Vertex pos="-1.9982 1.92836 0.5" />
                            <Vertex pos="2.59808 -1.92836 0.5" />
                            <Vertex pos="-2.59808 1.07164 -0.5" />
                            <Vertex pos="-1.9982 1.92836 -0.5" />
                            <Vertex pos="2.59808 -1.92836 -0.5" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.5" album="Blasted" material="bm_wood" texgens="1 0 0 -665.108 0 -1 0 -493.66 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 665.108 0 -1 0 -493.66 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.819153 0.573575 0 -2.74289" album="Blasted" material="bm_beam" texgens="0 0 -1 128 0.573575 0.819153 0 149.89 0 0.125 0.130733" texRot="0" texScale="0.125 0.130733" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.499999 -0.866026 0 -0.370971" album="Blasted" material="bm_wood" texgens="0 0 -1 0 -0.866026 0.499998 0 102.854 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.642786 0.766046 0 -0.192797" album="Blasted" material="bm_wood" texgens="0 0 -1 0 -0.866026 0.499998 0 102.854 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="231" owner="0" type="0" pos="-2.29814 2.29814 0" rot="1 0 0 0" scale="" transform="1 0 0 -2.29814 0 1 0 2.29814 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-2.29814 1.55857 0.5" />
                            <Vertex pos="-1.55857 2.29814 0.5" />
                            <Vertex pos="2.29814 -2.29814 0.5" />
                            <Vertex pos="-2.29814 1.55857 -0.5" />
                            <Vertex pos="-1.55857 2.29814 -0.5" />
                            <Vertex pos="2.29814 -2.29814 -0.5" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.5" album="Blasted" material="bm_wood" texgens="1 0 0 -588.324 0 -1 0 -588.324 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 588.324 0 -1 0 -588.324 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -2.72711" album="Blasted" material="bm_beam" texgens="0 0 -1 128 0.707107 0.707107 0 128 0 0.125 0.130739" texRot="0" texScale="0.125 0.130739" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.642785 -0.766047 0 -0.283273" album="Blasted" material="bm_wood" texgens="0 0 -1 0 -0.766047 0.642785 0 103.606 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.766047 0.642785 0 -0.283273" album="Blasted" material="bm_wood" texgens="0 0 -1 0 -0.766047 0.642785 0 103.606 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="232" owner="0" type="0" pos="-1.92836 2.59808 0" rot="1 0 0 0" scale="" transform="1 0 0 -1.92836 0 1 0 2.59808 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1.92836 1.99821 0.5" />
                            <Vertex pos="-1.07165 2.59808 0.5" />
                            <Vertex pos="1.92836 -2.59808 0.5" />
                            <Vertex pos="-1.92836 1.99821 -0.5" />
                            <Vertex pos="-1.07165 2.59808 -0.5" />
                            <Vertex pos="1.92836 -2.59808 -0.5" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.5" album="Blasted" material="bm_wood" texgens="1 0 0 -493.66 0 -1 0 -665.108 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 493.66 0 -1 0 -665.108 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.573573 0.819154 0 -2.7429" album="Blasted" material="bm_beam" texgens="0 0 -1 128 0.819154 0.573573 0 106.112 0 0.125 0.130731" texRot="0" texScale="0.125 0.130731" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.766047 -0.642785 0 -0.192794" album="Blasted" material="bm_wood" texgens="0 0 -1 0 -0.642785 0.766047 0 103.353 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.866025 0.500001 0 -0.370966" album="Blasted" material="bm_wood" texgens="0 0 -1 0 -0.642785 0.766047 0 103.353 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="233" owner="0" type="0" pos="-1.5 2.81908 0" rot="1 0 0 0" scale="" transform="1 0 0 -1.5 0 1 0 2.81908 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1.5 2.37708 0.5" />
                            <Vertex pos="-0.55214 2.81908 0.5" />
                            <Vertex pos="1.5 -2.81908 0.5" />
                            <Vertex pos="-1.5 2.37708 -0.5" />
                            <Vertex pos="-0.55214 2.81908 -0.5" />
                            <Vertex pos="1.5 -2.81908 -0.5" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.5" album="Blasted" material="bm_wood" texgens="1 0 0 -384 0 -1 0 -721.685 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 384 0 -1 0 -721.685 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.422623 0.906306 0 -2.7883" album="Blasted" material="bm_beam" texgens="0 0 -1 128 0.906306 0.422623 0 86.8595 0 0.125 0.130731" texRot="0" texScale="0.125 0.130731" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.866026 -0.499999 0 -0.1105" album="Blasted" material="bm_wood" texgens="0 0 -1 0 -0.5 0.866025 0 102.125 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.939692 0.342023 0 -0.445348" album="Blasted" material="bm_wood" texgens="0 0 -1 0 -0.5 0.866025 0 102.125 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="234" owner="0" type="0" pos="-1.02607 2.95443 0" rot="1 0 0 0" scale="" transform="1 0 0 -1.02607 0 1 0 2.95443 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1.02607 2.68373 0.5" />
                            <Vertex pos="-0.0158 2.95443 0.5" />
                            <Vertex pos="1.02607 -2.95443 0.5" />
                            <Vertex pos="-1.02607 2.68373 -0.5" />
                            <Vertex pos="-0.0158 2.95443 -0.5" />
                            <Vertex pos="1.02607 -2.95443 -0.5" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.5" album="Blasted" material="bm_wood" texgens="1 0 0 -262.674 0 -1 0 -756.334 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 262.674 0 -1 0 -756.334 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.258818 0.965926 0 -2.85785" album="Blasted" material="bm_beam" texgens="0 0 -1 128 0.965926 0.258818 0 72.575 0 0.125 0.130739" texRot="0" texScale="0.125 0.130739" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.939692 -0.342023 0 -0.0462927" album="Blasted" material="bm_wood" texgens="0 0 -1 0 -0.342023 0.939691 0 100.07 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.984808 0.173645 0 -0.497461" album="Blasted" material="bm_wood" texgens="0 0 -1 0 -0.342023 0.939691 0 100.07 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="235" owner="0" type="0" pos="-0.520932 3 0" rot="1 0 0 0" scale="" transform="1 0 0 -0.520932 0 1 0 3 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.520938 2.90885 0.5" />
                            <Vertex pos="0.520938 3 0.5" />
                            <Vertex pos="0.520932 -3 0.5" />
                            <Vertex pos="-0.520938 2.90885 -0.5" />
                            <Vertex pos="0.520938 3 -0.5" />
                            <Vertex pos="0.520932 -3 -0.5" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.5" album="Blasted" material="bm_wood" texgens="1 0 0 -133.359 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 133.359 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.0871536 0.996195 0 -2.94318" album="Blasted" material="bm_beam" texgens="0 0 -1 128 0.996195 0.0871533 0 64.9732 0 0.125 0.130732" texRot="0" texScale="0.125 0.130732" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.984808 -0.173645 0 -0.00791675" album="Blasted" material="bm_wood" texgens="0 0 -1 0 -0.173645 0.984808 0 97.4362 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="1 -9.93411e-007 0 -0.520935" album="Blasted" material="bm_wood" texgens="0 0 -1 0 -0.173645 0.984808 0 97.4362 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="236" owner="0" type="0" pos="0.52094 3 0" rot="1 0 0 0" scale="" transform="1 0 0 0.52094 0 1 0 3 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.520934 3 0.5" />
                            <Vertex pos="0.52094 2.90885 0.5" />
                            <Vertex pos="-0.52094 -3 0.5" />
                            <Vertex pos="-0.520934 3 -0.5" />
                            <Vertex pos="0.52094 2.90885 -0.5" />
                            <Vertex pos="-0.52094 -3 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.5" album="Blasted" material="bm_wood" texgens="1 0 0 133.361 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 -133.361 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.0871537 0.996195 0 -2.94318" album="Blasted" material="bm_beam" texgens="0 0 -1 128 0.996195 -0.0871535 0 191.026 0 0.125 0.130732" texRot="0" texScale="0.125 0.130732" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-1 1.00334e-006 0 -0.520937" album="Blasted" material="bm_wood" texgens="0 0 -1 0 0 1 0 96 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.984808 -0.173647 0 -0.00791401" album="Blasted" material="bm_wood" texgens="0 0 -1 0 0 1 0 96 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="237" owner="0" type="0" pos="1.02604 2.95442 0" rot="1 0 0 0" scale="" transform="1 0 0 1.02604 0 1 0 2.95442 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.0158352 2.95442 0.5" />
                            <Vertex pos="1.02604 2.68374 0.5" />
                            <Vertex pos="-1.02604 -2.95442 0.5" />
                            <Vertex pos="0.0158352 2.95442 -0.5" />
                            <Vertex pos="1.02604 2.68374 -0.5" />
                            <Vertex pos="-1.02604 -2.95442 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.5" album="Blasted" material="bm_wood" texgens="1 0 0 262.666 0 -1 0 -756.332 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 -262.666 0 -1 0 -756.332 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.258816 0.965927 0 -2.85785" album="Blasted" material="bm_beam" texgens="0 0 -1 128 0.965927 -0.258815 0 183.426 0 0.125 0.130731" texRot="0" texScale="0.125 0.130731" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.984808 0.173646 0 -0.497429" album="Blasted" material="bm_wood" texgens="0 0 -1 0 0.173647 0.984808 0 98.8066 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.939695 -0.342014 0 -0.0462882" album="Blasted" material="bm_wood" texgens="0 0 -1 0 0.173647 0.984808 0 98.8066 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="238" owner="0" type="0" pos="1.50001 2.81909 -2.98023e-008" rot="1 0 0 0" scale="" transform="1 0 0 1.50001 0 1 0 2.81909 0 0 1 -2.98023e-008 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.552085 2.81909 0.5" />
                            <Vertex pos="1.50001 2.37707 0.5" />
                            <Vertex pos="-1.50001 -2.81909 0.5" />
                            <Vertex pos="0.552085 2.81909 -0.5" />
                            <Vertex pos="1.50001 2.37707 -0.5" />
                            <Vertex pos="-1.50001 -2.81909 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.5" album="Blasted" material="bm_wood" texgens="1 0 0 384.003 0 -1 0 -721.687 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 -384.003 0 -1 0 -721.687 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.422615 0.90631 0 -2.78829" album="Blasted" material="bm_beam" texgens="0 0 -1 128 0.906309 -0.422616 0 169.139 0 0.125 0.130739" texRot="0" texScale="0.125 0.130739" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.939694 0.342015 0 -0.44538" album="Blasted" material="bm_wood" texgens="0 0 -1 0 0.342015 0.939695 0 101.188 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.866024 -0.500002 0 -0.110505" album="Blasted" material="bm_wood" texgens="0 0 -1 0 0.342015 0.939695 0 101.188 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="239" owner="0" type="0" pos="1.92836 2.59807 -2.98023e-008" rot="1 0 0 0" scale="" transform="1 0 0 1.92836 0 1 0 2.59807 0 0 1 -2.98023e-008 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1.07165 2.59807 0.5" />
                            <Vertex pos="1.92836 1.9982 0.5" />
                            <Vertex pos="-1.92836 -2.59807 0.5" />
                            <Vertex pos="1.07165 2.59807 -0.5" />
                            <Vertex pos="1.92836 1.9982 -0.5" />
                            <Vertex pos="-1.92836 -2.59807 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.5" album="Blasted" material="bm_wood" texgens="1 0 0 493.66 0 -1 0 -665.106 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 -493.66 0 -1 0 -665.106 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.573573 0.819154 0 -2.74289" album="Blasted" material="bm_beam" texgens="0 0 -1 128 0.81915 -0.573579 0 149.891 0 0.125 0.130732" texRot="0" texScale="0.125 0.130732" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.866024 0.500002 0 -0.370966" album="Blasted" material="bm_wood" texgens="0 0 -1 0 0.500002 0.866025 0 102.854 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.766045 -0.642787 0 -0.192794" album="Blasted" material="bm_wood" texgens="0 0 -1 0 0.500002 0.866025 0 102.854 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="240" owner="0" type="0" pos="2.29813 2.29813 0" rot="1 0 0 0" scale="" transform="1 0 0 2.29813 0 1 0 2.29813 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1.55859 2.29813 0.5" />
                            <Vertex pos="2.29813 1.55861 0.5" />
                            <Vertex pos="-2.29813 -2.29813 0.5" />
                            <Vertex pos="1.55859 2.29813 -0.5" />
                            <Vertex pos="2.29813 1.55861 -0.5" />
                            <Vertex pos="-2.29813 -2.29813 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.5" album="Blasted" material="bm_wood" texgens="1 0 0 588.321 0 -1 0 -588.321 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 -588.321 0 -1 0 -588.321 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.707097 0.707116 0 -2.72712" album="Blasted" material="bm_beam" texgens="0 0 -1 128 0.707107 -0.707107 0 128.002 0 0.125 0.130732" texRot="0" texScale="0.125 0.130732" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.766045 0.642788 0 -0.28326" album="Blasted" material="bm_wood" texgens="0 0 -1 0 0.642787 0.766045 0 103.606 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.64279 -0.766043 0 -0.283252" album="Blasted" material="bm_wood" texgens="0 0 -1 0 0.642787 0.766045 0 103.606 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="241" owner="0" type="0" pos="2.59808 1.92837 0" rot="1 0 0 0" scale="" transform="1 0 0 2.59808 0 1 0 1.92837 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1.99817 1.92837 0.5" />
                            <Vertex pos="2.59808 1.07161 0.5" />
                            <Vertex pos="-2.59808 -1.92837 0.5" />
                            <Vertex pos="1.99817 1.92837 -0.5" />
                            <Vertex pos="2.59808 1.07161 -0.5" />
                            <Vertex pos="-2.59808 -1.92837 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.5" album="Blasted" material="bm_wood" texgens="1 0 0 665.108 0 -1 0 -493.663 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 -665.108 0 -1 0 -493.663 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.819152 0.573576 0 -2.74287" album="Blasted" material="bm_beam" texgens="0 0 -1 128 0.573577 -0.819152 0 106.111 0 0.125 0.130739" texRot="0" texScale="0.125 0.130739" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.64279 0.766042 0 -0.192808" album="Blasted" material="bm_wood" texgens="0 0 -1 0 0.766042 0.64279 0 103.353 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.499997 -0.866027 0 -0.370989" album="Blasted" material="bm_wood" texgens="0 0 -1 0 0.766042 0.64279 0 103.353 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="242" owner="0" type="0" pos="2.81908 1.49999 0" rot="1 0 0 0" scale="" transform="1 0 0 2.81908 0 1 0 1.49999 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="2.37708 1.49999 0.5" />
                            <Vertex pos="2.81908 0.55213 0.5" />
                            <Vertex pos="-2.81908 -1.49999 0.5" />
                            <Vertex pos="2.37708 1.49999 -0.5" />
                            <Vertex pos="2.81908 0.55213 -0.5" />
                            <Vertex pos="-2.81908 -1.49999 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.5" album="Blasted" material="bm_wood" texgens="1 0 0 721.685 0 -1 0 -383.997 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 -721.685 0 -1 0 -383.997 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.906306 0.422623 0 -2.78829" album="Blasted" material="bm_beam" texgens="0 0 -1 128 0.422623 -0.906306 0 86.8569 0 0.125 0.130731" texRot="0" texScale="0.125 0.130731" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.499997 0.866027 0 -0.1105" album="Blasted" material="bm_wood" texgens="0 0 -1 0 0.866027 0.499997 0 102.124 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.34202 -0.939693 0 -0.445349" album="Blasted" material="bm_wood" texgens="0 0 -1 0 0.866027 0.499997 0 102.124 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="243" owner="0" type="0" pos="2.95442 1.02606 -2.98023e-008" rot="1 0 0 0" scale="" transform="1 0 0 2.95442 0 1 0 1.02606 0 0 1 -2.98023e-008 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="2.68374 1.02606 0.5" />
                            <Vertex pos="2.95442 0.0158399 0.5" />
                            <Vertex pos="-2.95442 -1.02606 0.5" />
                            <Vertex pos="2.68374 1.02606 -0.5" />
                            <Vertex pos="2.95442 0.0158399 -0.5" />
                            <Vertex pos="-2.95442 -1.02606 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.5" album="Blasted" material="bm_wood" texgens="1 0 0 756.332 0 -1 0 -262.671 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 -756.332 0 -1 0 -262.671 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.965928 0.258812 0 -2.85786" album="Blasted" material="bm_beam" texgens="0 0 -1 128 0.258812 -0.965928 0 72.5797 0 0.125 0.130732" texRot="0" texScale="0.125 0.130732" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.34202 0.939693 0 -0.046289" album="Blasted" material="bm_wood" texgens="0 0 -1 0 0.939693 0.34202 0 100.07 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.17365 -0.984807 0 -0.497436" album="Blasted" material="bm_wood" texgens="0 0 -1 0 0.939693 0.34202 0 100.07 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="244" owner="0" type="0" pos="3 0.52095 0" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 0.52095 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="2.90884 0.52095 0.5" />
                            <Vertex pos="3 -0.52095 0.5" />
                            <Vertex pos="-3 -0.52095 0.5" />
                            <Vertex pos="2.90884 0.52095 -0.5" />
                            <Vertex pos="3 -0.52095 -0.5" />
                            <Vertex pos="-3 -0.52095 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.5" album="Blasted" material="bm_wood" texgens="1 0 0 768 0 -1 0 -133.363 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 -768 0 -1 0 -133.363 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.996194 0.0871611 0 -2.94318" album="Blasted" material="bm_beam" texgens="0 0 -1 128 0.0871608 -0.996194 0 64.9694 0 0.125 0.130735" texRot="0" texScale="0.125 0.130735" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.17365 0.984807 0 -0.00791502" album="Blasted" material="bm_wood" texgens="0 0 -1 0 0.984807 0.17365 0 97.4363 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0 -1 0 -0.52095" album="Blasted" material="bm_wood" texgens="0 0 -1 0 0.984807 0.17365 0 97.4363 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="245" owner="0" type="0" pos="-53 0 -60.75" rot="1 0 0 0" scale="" transform="1 0 0 -53 0 1 0 0 0 0 1 -60.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.500004 7 0.25" />
                            <Vertex pos="3.8147e-006 7 -0.25" />
                            <Vertex pos="0.500004 -7 0.25" />
                            <Vertex pos="3.8147e-006 -7 -0.25" />
                            <Vertex pos="-0.500004 7 0.25" />
                            <Vertex pos="-0.500004 7 -0.25" />
                            <Vertex pos="-0.500004 -7 0.25" />
                            <Vertex pos="-0.500004 -7 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0 -0.707107 -0.176779" album="" material="bm_beam_metal" texgens="0 1 0 3584 0 0 -1 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.500004" album="" material="bm_beam_metal" texgens="0 0 -1 128 0 1 0 3584 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -7" album="" material="bm_beam_metal" texgens="0 0 -1 128 1 0 0 256.004 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -7" album="" material="bm_beam_metal" texgens="0 0 -1 128 -1 0 0 768 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile11_A" texgens="1 0 0 128.001 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_beam_metal" texgens="-1 0 0 -0.00390625 0 -1 0 -3328 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="246" owner="0" type="0" pos="-52.75 0 -61.5" rot="1 0 0 0" scale="" transform="1 0 0 -52.75 0 1 0 0 0 0 1 -61.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 7 0.999992" />
                            <Vertex pos="0.25 7 -1" />
                            <Vertex pos="0.25 -7 0.999992" />
                            <Vertex pos="0.25 -7 -1" />
                            <Vertex pos="-0.25 7 0.499992" />
                            <Vertex pos="-0.25 7 -0.5" />
                            <Vertex pos="-0.25 -7 0.499992" />
                            <Vertex pos="-0.25 -7 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_beam_metal" texgens="0 1 0 3584 0 0 -1 256 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_beam_metal" texgens="0 0 -1 128 0 1 0 1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -7" album="" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 256 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -7" album="" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 256 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -0.530325" album="" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 -3328 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 0 -0.707107 -0.53033" album="" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 -3328 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="247" owner="0" type="0" pos="-52.25 0 -61.5" rot="1 0 0 0" scale="" transform="1 0 0 -52.25 0 1 0 0 0 0 1 -61.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 7 0.5" />
                            <Vertex pos="0.25 7 -0.5" />
                            <Vertex pos="0.25 -7 0.5" />
                            <Vertex pos="0.25 -7 -0.5" />
                            <Vertex pos="-0.25 7 1" />
                            <Vertex pos="-0.25 7 -1" />
                            <Vertex pos="-0.25 -7 1" />
                            <Vertex pos="-0.25 -7 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_beam_metal" texgens="0 0 -1 128 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_beam_metal" texgens="0 -1 0 -3328 0 0 -1 256 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -7" album="" material="bm_beam_metal" texgens="-1 0 0 128 0 0 -1 256 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -7" album="" material="bm_beam_metal" texgens="1 0 0 128 0 0 -1 256 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -0.53033" album="" material="bm_beam_metal" texgens="1 0 0 128 0 -1 0 -3328 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -0.53033" album="" material="bm_beam_metal" texgens="-1 0 0 128 0 -1 0 -3328 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="248" owner="0" type="0" pos="-52 0 -60.75" rot="1 0 0 0" scale="" transform="1 0 0 -52 0 1 0 0 0 0 1 -60.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 7 0.25" />
                            <Vertex pos="0.5 7 -0.25" />
                            <Vertex pos="0.5 -7 0.25" />
                            <Vertex pos="0.5 -7 -0.25" />
                            <Vertex pos="-0.5 7 0.25" />
                            <Vertex pos="0 7 -0.25" />
                            <Vertex pos="-0.5 -7 0.25" />
                            <Vertex pos="0 -7 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_beam_metal" texgens="0 0 -1 128 0 -1 0 -2560 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0 -0.707107 -0.176777" album="" material="bm_beam_metal" texgens="0 -1 0 -3328 0 0 -1 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -7" album="" material="bm_beam_metal" texgens="0 0 -1 128 1 0 0 256.002 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -7" album="" material="bm_beam_metal" texgens="0 0 -1 128 -1 0 0 1024 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile11_A" texgens="1 0 0 384 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_beam_metal" texgens="-1 0 0 256 0 -1 0 -3328 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="249" owner="0" type="0" pos="-53 0 -62.25" rot="1 0 0 0" scale="" transform="1 0 0 -53 0 1 0 0 0 0 1 -62.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0 7 0.25" />
                            <Vertex pos="0.5 7 -0.25" />
                            <Vertex pos="0 -7 0.25" />
                            <Vertex pos="0.5 -7 -0.25" />
                            <Vertex pos="-0.5 7 0.25" />
                            <Vertex pos="-0.5 7 -0.25" />
                            <Vertex pos="-0.5 -7 0.25" />
                            <Vertex pos="-0.5 -7 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0 0.707107 -0.176777" album="" material="bm_beam_metal" texgens="0 1 0 3584 0 0 -1 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_beam_metal" texgens="0 0 -1 128 0 1 0 3584 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 0 -7" album="" material="bm_beam_metal" texgens="0 0 -1 128 1 0 0 256.002 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -7" album="" material="bm_beam_metal" texgens="0 0 -1 128 -1 0 0 512.002 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_beam_metal" texgens="1 0 0 512 0 -1 0 -3328 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_beam_metal" texgens="-1 0 0 192 0 -1 0 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="250" owner="0" type="0" pos="-52 0 -62.25" rot="1 0 0 0" scale="" transform="1 0 0 -52 0 1 0 0 0 0 1 -62.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 7 0.25" />
                            <Vertex pos="0.5 7 -0.25" />
                            <Vertex pos="0.5 -7 0.25" />
                            <Vertex pos="0.5 -7 -0.25" />
                            <Vertex pos="0 7 0.25" />
                            <Vertex pos="-0.5 7 -0.25" />
                            <Vertex pos="0 -7 0.25" />
                            <Vertex pos="-0.5 -7 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_beam_metal" texgens="0 0 -1 128 0 -1 0 -2560 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0 0.707107 -0.176777" album="" material="bm_beam_metal" texgens="0 -1 0 -3328 0 0 -1 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -7" album="" material="bm_beam_metal" texgens="0 0 -1 128 1 0 0 256.003 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 -0 -7" album="" material="bm_beam_metal" texgens="0 0 -1 128 -1 0 0 1280 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_beam_metal" texgens="1 0 0 -256 0 -1 0 -3328 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_beam_metal" texgens="-1 0 0 64 0 -1 0 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="254" owner="0" type="0" pos="-50.75 -8.75 -56.5" rot="1 0 0 0" scale="" transform="1 0 0 -50.75 0 1 0 -8.75 0 0 1 -56.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.5 2.375 16" />
                            <Vertex pos="-0.5 2.375 -6" />
                            <Vertex pos="-0.5 2.125 16" />
                            <Vertex pos="-0.5 2.125 -6" />
                            <Vertex pos="-0.75 2.375 16" />
                            <Vertex pos="-0.75 2.375 -6" />
                            <Vertex pos="-0.75 2.125 16" />
                            <Vertex pos="-0.75 2.125 -6" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 0.5" album="Blasted" material="bm_wood" texgens="0 1 0 -2240 0 0 -1 14464 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.75" album="Blasted" material="bm_wood" texgens="0 -1 0 2240 0 0 -1 14464 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.375" album="Blasted" material="bm_wood" texgens="-1 0 0 12992 0 0 -1 14464 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 2.125" album="Blasted" material="bm_wood" texgens="1 0 0 -12992 0 0 -1 14464 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16" album="Blasted" material="bm_wood" texgens="0 -1 0 2240 -1 0 0 12992 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -6" album="Blasted" material="bm_wood" texgens="0 -1 0 2240 1 0 0 -12992 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="255" owner="0" type="0" pos="-50.75 12.25 -56.5" rot="1 0 0 0" scale="" transform="1 0 0 -50.75 0 1 0 12.25 0 0 1 -56.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.5 -5.625 16" />
                            <Vertex pos="-0.5 -5.625 -6" />
                            <Vertex pos="-0.5 -5.875 16" />
                            <Vertex pos="-0.5 -5.875 -6" />
                            <Vertex pos="-0.75 -5.625 16" />
                            <Vertex pos="-0.75 -5.625 -6" />
                            <Vertex pos="-0.75 -5.875 16" />
                            <Vertex pos="-0.75 -5.875 -6" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 0.5" album="Blasted" material="bm_wood" texgens="0 1 0 3136 0 0 -1 14464 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.75" album="Blasted" material="bm_wood" texgens="0 -1 0 -3136 0 0 -1 14464 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 5.625" album="Blasted" material="bm_wood" texgens="-1 0 0 12992 0 0 -1 14464 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.875" album="Blasted" material="bm_wood" texgens="1 0 0 -12992 0 0 -1 14464 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16" album="Blasted" material="bm_wood" texgens="0 -1 0 -3136 -1 0 0 12992 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -6" album="Blasted" material="bm_wood" texgens="0 -1 0 -3136 1 0 0 -12992 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="256" owner="0" type="0" pos="-53 -8.75 -56.5" rot="1 0 0 0" scale="" transform="1 0 0 -53 0 1 0 -8.75 0 0 1 -56.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.5 2.375 16" />
                            <Vertex pos="-0.5 2.375 -6" />
                            <Vertex pos="-0.5 2.125 16" />
                            <Vertex pos="-0.5 2.125 -6" />
                            <Vertex pos="-0.75 2.375 16" />
                            <Vertex pos="-0.75 2.375 -6" />
                            <Vertex pos="-0.75 2.125 16" />
                            <Vertex pos="-0.75 2.125 -6" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 0.5" album="Blasted" material="bm_wood" texgens="0 1 0 -2240 0 0 -1 14464 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.75" album="Blasted" material="bm_wood" texgens="0 -1 0 2240 0 0 -1 14464 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.375" album="Blasted" material="bm_wood" texgens="-1 0 0 13568 0 0 -1 14464 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 2.125" album="Blasted" material="bm_wood" texgens="1 0 0 -13568 0 0 -1 14464 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16" album="Blasted" material="bm_wood" texgens="0 -1 0 2240 -1 0 0 13568 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -6" album="Blasted" material="bm_wood" texgens="0 -1 0 2240 1 0 0 -13568 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="257" owner="0" type="0" pos="-53 12.25 -56.5" rot="1 0 0 0" scale="" transform="1 0 0 -53 0 1 0 12.25 0 0 1 -56.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.5 -5.625 16" />
                            <Vertex pos="-0.5 -5.625 -6" />
                            <Vertex pos="-0.5 -5.875 16" />
                            <Vertex pos="-0.5 -5.875 -6" />
                            <Vertex pos="-0.75 -5.625 16" />
                            <Vertex pos="-0.75 -5.625 -6" />
                            <Vertex pos="-0.75 -5.875 16" />
                            <Vertex pos="-0.75 -5.875 -6" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 0.5" album="Blasted" material="bm_wood" texgens="0 1 0 3136 0 0 -1 14464 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.75" album="Blasted" material="bm_wood" texgens="0 -1 0 -3136 0 0 -1 14464 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 5.625" album="Blasted" material="bm_wood" texgens="-1 0 0 13568 0 0 -1 14464 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.875" album="Blasted" material="bm_wood" texgens="1 0 0 -13568 0 0 -1 14464 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16" album="Blasted" material="bm_wood" texgens="0 -1 0 -3136 -1 0 0 13568 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -6" album="Blasted" material="bm_wood" texgens="0 -1 0 -3136 1 0 0 -13568 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="258" owner="0" type="0" pos="-53 -8.75 -56.75" rot="1 0 0 0" scale="" transform="1 0 0 -53 0 1 0 -8.75 0 0 1 -56.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.75 2.375 -5.75" />
                            <Vertex pos="1.75 2.375 -6" />
                            <Vertex pos="1.75 2.125 -5.75" />
                            <Vertex pos="1.75 2.125 -6" />
                            <Vertex pos="-0.75 2.375 -5.75" />
                            <Vertex pos="-0.75 2.375 -6" />
                            <Vertex pos="-0.75 2.125 -5.75" />
                            <Vertex pos="-0.75 2.125 -6" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.75" album="Blasted" material="bm_wood" texgens="0 1 0 -2240 0 0 -1 14528 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.75" album="Blasted" material="bm_wood" texgens="0 -1 0 2240 0 0 -1 14528 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.375" album="Blasted" material="bm_wood" texgens="-1 0 0 13568 0 0 -1 14528 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 2.125" album="Blasted" material="bm_wood" texgens="1 0 0 -13568 0 0 -1 14528 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 5.75" album="Blasted" material="bm_wood" texgens="0 -1 0 2240 -1 0 0 13568 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -6" album="Blasted" material="bm_wood" texgens="0 -1 0 2240 1 0 0 -13568 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="259" owner="0" type="0" pos="-53 12.25 -56.75" rot="1 0 0 0" scale="" transform="1 0 0 -53 0 1 0 12.25 0 0 1 -56.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.75 -5.625 -5.75" />
                            <Vertex pos="1.75 -5.625 -6" />
                            <Vertex pos="1.75 -5.875 -5.75" />
                            <Vertex pos="1.75 -5.875 -6" />
                            <Vertex pos="-0.75 -5.625 -5.75" />
                            <Vertex pos="-0.75 -5.625 -6" />
                            <Vertex pos="-0.75 -5.875 -5.75" />
                            <Vertex pos="-0.75 -5.875 -6" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.75" album="Blasted" material="bm_wood" texgens="0 1 0 3136 0 0 -1 14528 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.75" album="Blasted" material="bm_wood" texgens="0 -1 0 -3136 0 0 -1 14528 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 5.625" album="Blasted" material="bm_wood" texgens="-1 0 0 13568 0 0 -1 14528 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.875" album="Blasted" material="bm_wood" texgens="1 0 0 -13568 0 0 -1 14528 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 5.75" album="Blasted" material="bm_wood" texgens="0 -1 0 -3136 -1 0 0 13568 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -6" album="Blasted" material="bm_wood" texgens="0 -1 0 -3136 1 0 0 -13568 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="260" owner="0" type="0" pos="-53.25 12.25 -34.75" rot="1 0 0 0" scale="" transform="1 0 0 -53.25 0 1 0 12.25 0 0 1 -34.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.75 -5.625 -5.75" />
                            <Vertex pos="1.75 -5.625 -6" />
                            <Vertex pos="1.75 -5.875 -5.75" />
                            <Vertex pos="1.75 -5.875 -6" />
                            <Vertex pos="-0.25 -5.625 -5.75" />
                            <Vertex pos="-0.25 -5.625 -6" />
                            <Vertex pos="-0.25 -5.875 -5.75" />
                            <Vertex pos="-0.25 -5.875 -6" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.75" album="Blasted" material="bm_wood" texgens="0 1 0 3136 0 0 -1 8896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_wood" texgens="0 -1 0 -3136 0 0 -1 8896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 5.625" album="Blasted" material="bm_wood" texgens="-1 0 0 13632 0 0 -1 8896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.875" album="Blasted" material="bm_wood" texgens="1 0 0 -13632 0 0 -1 8896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 5.75" album="Blasted" material="bm_wood" texgens="0 -1 0 -3136 -1 0 0 13632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -6" album="Blasted" material="bm_wood" texgens="0 -1 0 -3136 1 0 0 -13632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="261" owner="0" type="0" pos="-53.25 -8.75 -34.75" rot="1 0 0 0" scale="" transform="1 0 0 -53.25 0 1 0 -8.75 0 0 1 -34.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.75 2.375 -5.75" />
                            <Vertex pos="1.75 2.375 -6" />
                            <Vertex pos="1.75 2.125 -5.75" />
                            <Vertex pos="1.75 2.125 -6" />
                            <Vertex pos="-0.25 2.375 -5.75" />
                            <Vertex pos="-0.25 2.375 -6" />
                            <Vertex pos="-0.25 2.125 -5.75" />
                            <Vertex pos="-0.25 2.125 -6" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.75" album="Blasted" material="bm_wood" texgens="0 1 0 -2240 0 0 -1 8896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_wood" texgens="0 -1 0 2240 0 0 -1 8896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.375" album="Blasted" material="bm_wood" texgens="-1 0 0 13632 0 0 -1 8896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 2.125" album="Blasted" material="bm_wood" texgens="1 0 0 -13632 0 0 -1 8896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 5.75" album="Blasted" material="bm_wood" texgens="0 -1 0 2240 -1 0 0 13632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -6" album="Blasted" material="bm_wood" texgens="0 -1 0 2240 1 0 0 -13632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="262" owner="0" type="0" pos="-53 -2 -34.75" rot="1 0 0 0" scale="" transform="1 0 0 -53 0 1 0 -2 0 0 1 -34.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.75 8.375 -5.75" />
                            <Vertex pos="1.75 8.375 -6" />
                            <Vertex pos="1.75 -4.375 -5.75" />
                            <Vertex pos="1.75 -4.375 -6" />
                            <Vertex pos="1.5 8.375 -5.75" />
                            <Vertex pos="1.5 8.375 -6" />
                            <Vertex pos="1.5 -4.375 -5.75" />
                            <Vertex pos="1.5 -4.375 -6" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.75" album="Blasted" material="bm_wood" texgens="0 1 0 -512 0 0 -1 8896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 1.5" album="Blasted" material="bm_wood" texgens="0 -1 0 512 0 0 -1 8896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8.375" album="Blasted" material="bm_wood" texgens="-1 0 0 13568 0 0 -1 8896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4.375" album="Blasted" material="bm_wood" texgens="1 0 0 -13568 0 0 -1 8896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 5.75" album="Blasted" material="bm_wood" texgens="0 -1 0 512 -1 0 0 13568 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -6" album="Blasted" material="bm_wood" texgens="0 -1 0 512 1 0 0 -13568 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="263" owner="0" type="0" pos="-55.25 -2 -34.75" rot="1 0 0 0" scale="" transform="1 0 0 -55.25 0 1 0 -2 0 0 1 -34.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.75 8.375 -5.75" />
                            <Vertex pos="1.75 8.375 -6" />
                            <Vertex pos="1.75 -4.375 -5.75" />
                            <Vertex pos="1.75 -4.375 -6" />
                            <Vertex pos="1.5 8.375 -5.75" />
                            <Vertex pos="1.5 8.375 -6" />
                            <Vertex pos="1.5 -4.375 -5.75" />
                            <Vertex pos="1.5 -4.375 -6" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.75" album="Blasted" material="bm_wood" texgens="0 1 0 -512 0 0 -1 8896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 1.5" album="Blasted" material="bm_wood" texgens="0 -1 0 512 0 0 -1 8896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8.375" album="Blasted" material="bm_wood" texgens="-1 0 0 14144 0 0 -1 8896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4.375" album="Blasted" material="bm_wood" texgens="1 0 0 -14144 0 0 -1 8896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 5.75" album="Blasted" material="bm_wood" texgens="0 -1 0 512 -1 0 0 14144 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -6" album="Blasted" material="bm_wood" texgens="0 -1 0 512 1 0 0 -14144 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="264" owner="0" type="0" pos="-53 -2 -56.75" rot="1 0 0 0" scale="" transform="1 0 0 -53 0 1 0 -2 0 0 1 -56.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.75 8.375 -5.75" />
                            <Vertex pos="1.75 8.375 -6" />
                            <Vertex pos="1.75 -4.375 -5.75" />
                            <Vertex pos="1.75 -4.375 -6" />
                            <Vertex pos="1.5 8.375 -5.75" />
                            <Vertex pos="1.5 8.375 -6" />
                            <Vertex pos="1.5 -4.375 -5.75" />
                            <Vertex pos="1.5 -4.375 -6" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.75" album="Blasted" material="bm_wood" texgens="0 1 0 -512 0 0 -1 14528 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 1.5" album="Blasted" material="bm_wood" texgens="0 -1 0 512 0 0 -1 14528 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8.375" album="Blasted" material="bm_wood" texgens="-1 0 0 13568 0 0 -1 14528 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4.375" album="Blasted" material="bm_wood" texgens="1 0 0 -13568 0 0 -1 14528 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 5.75" album="Blasted" material="bm_wood" texgens="0 -1 0 512 -1 0 0 13568 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -6" album="Blasted" material="bm_wood" texgens="0 -1 0 512 1 0 0 -13568 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="265" owner="0" type="0" pos="-55.25 -2 -56.75" rot="1 0 0 0" scale="" transform="1 0 0 -55.25 0 1 0 -2 0 0 1 -56.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.75 8.375 -5.75" />
                            <Vertex pos="1.75 8.375 -6" />
                            <Vertex pos="1.75 -4.375 -5.75" />
                            <Vertex pos="1.75 -4.375 -6" />
                            <Vertex pos="1.5 8.375 -5.75" />
                            <Vertex pos="1.5 8.375 -6" />
                            <Vertex pos="1.5 -4.375 -5.75" />
                            <Vertex pos="1.5 -4.375 -6" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.75" album="Blasted" material="bm_wood" texgens="0 1 0 -512 0 0 -1 14528 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 1.5" album="Blasted" material="bm_wood" texgens="0 -1 0 512 0 0 -1 14528 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8.375" album="Blasted" material="bm_wood" texgens="-1 0 0 14144 0 0 -1 14528 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4.375" album="Blasted" material="bm_wood" texgens="1 0 0 -14144 0 0 -1 14528 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 5.75" album="Blasted" material="bm_wood" texgens="0 -1 0 512 -1 0 0 14144 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -6" album="Blasted" material="bm_wood" texgens="0 -1 0 512 1 0 0 -14144 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                </Brushes>
            </InteriorMap>
        </DetailLevel>
    </DetailLevels>
</ConstructorScene>
