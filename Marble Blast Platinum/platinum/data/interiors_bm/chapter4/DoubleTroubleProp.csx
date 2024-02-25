<?xml version="1.0" encoding="utf-8" standalone="yes" ?>
<!--Torque Constructor Scene document http://www.garagegames.com-->
<ConstructorScene version="4" creator="Torque Constructor" date="2024/02/24 23:49:59">
    <Sunlight azimuth="180" elevation="35" color="100 100 100" ambient="64 64 64" />
    <LightingOptions lightingSystem="" ineditor_defaultLightmapSize="256" ineditor_maxLightmapSize="256" ineditor_lightingPerformanceHint="0" ineditor_shadowPerformanceHint="1" ineditor_TAPCompatibility="0" ineditor_useSunlight="0" export_defaultLightmapSize="256" export_maxLightmapSize="256" export_lightingPerformanceHint="0" export_shadowPerformanceHint="1" export_TAPCompatibility="0" export_useSunlight="0" />
    <GameTypes>
        <GameType name="Constructor" />
        <GameType name="Torque" />
    </GameTypes>
    <DetailLevels current="0">
        <DetailLevel minPixelSize="0" actionCenter="0 0 0">
            <InteriorMap brushScale="32" lightScale="8" ambientColor="0 0 0" ambientColorEmerg="0 0 0">
                <Entities nextEntityID="1">
                    <Entity id="0" classname="worldspawn" gametype="Torque" isPointEntity="0">
                        <Properties detail_number="0" min_pixels="250" geometry_scale="32" light_geometry_scale="8" ambient_color="0 0 0" emergency_ambient_color="0 0 0" mapversion="220" />
                    </Entity>
                </Entities>
                <Brushes nextBrushID="39">
                    <Brush id="0" owner="0" type="0" pos="0 0 2" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 0 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 -0.25 0.5" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                            <Vertex pos="-0.25 0.25 0.5" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                            <Vertex pos="0.25 -0.25 0.5" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="0.25 0.25 0.5" />
                            <Vertex pos="0.5 0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="-0.970143 0 0.242536 -0.363804" album="Blasted" material="bm_wood" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0.970143 -0 0.242536 -0.363804" album="Blasted" material="bm_wood" texgens="0 1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 -0.970143 0.242536 -0.363804" album="Blasted" material="bm_wood" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 0.970143 0.242536 -0.363804" album="Blasted" material="bm_wood" texgens="-1 0 0 127.999 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0 1 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 127.999 0 1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_wood" texgens="1 0 0 128 0 1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="1" owner="0" type="0" pos="0 0 6.5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 0 0 0 1 6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 -0.25 4" />
                            <Vertex pos="-0.25 -0.25 -4" />
                            <Vertex pos="-0.25 0.25 4" />
                            <Vertex pos="-0.25 0.25 -4" />
                            <Vertex pos="0.25 -0.25 4" />
                            <Vertex pos="0.25 -0.25 -4" />
                            <Vertex pos="0.25 0.25 4" />
                            <Vertex pos="0.25 0.25 -4" />
                        </Vertices>
                        <Face id="0" plane="-1 -0 -0 -0.25" album="Blasted" material="bm_beam_wood" texgens="0 -1 0 128 0 0 -1 -1792 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 0 0 -0.25" album="Blasted" material="bm_beam_wood" texgens="0 1 0 128 0 0 -1 -1792 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 -1 0 -0.25" album="Blasted" material="bm_beam_wood" texgens="1 0 0 128.001 0 0 -1 -1792 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 1 0 -0.25" album="Blasted" material="bm_beam_wood" texgens="-1 0 0 127.999 0 0 -1 -1792 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0 1 -4" album="Blasted" material="bm_beam_wood" texgens="-1 0 0 127.999 0 1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="Blasted" material="bm_beam_wood" texgens="1 0 0 128.001 0 1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="2" owner="0" type="0" pos="1.25 0 9.25" rot="1 0 0 0" scale="" transform="1 0 0 1.25 0 1 0 0 0 0 1 9.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -0.25 1.25" />
                            <Vertex pos="-1 -0.25 0.75" />
                            <Vertex pos="-1 0.25 1.25" />
                            <Vertex pos="-1 0.25 0.75" />
                            <Vertex pos="1 -0.25 -0.750001" />
                            <Vertex pos="1 -0.25 -1.25" />
                            <Vertex pos="1 0.25 -0.750001" />
                            <Vertex pos="1 0.25 -1.25" />
                        </Vertices>
                        <Face id="0" plane="-1 -0 -0 -1" album="Blasted" material="bm_beam_wood" texgens="0 -1 0 128 0 0 -1 -3200 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 0 0 -1" album="Blasted" material="bm_beam_wood" texgens="0 1 0 128 0 0 -1 -3200 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 -1 0 -0.25" album="Blasted" material="bm_beam_wood" texgens="1 0 1 73601.7 0 0 -1 640 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 1 0 -0.25" album="Blasted" material="bm_beam_wood" texgens="-1 0 -1 128.34 0 0 -1 640 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 -0 0.707107 -0.176776" album="Blasted" material="bm_beam_wood" texgens="0 1 0 128 1 0 0 512.002 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 -0 -0.707107 -0.176777" album="Blasted" material="bm_beam_wood" texgens="0 1 0 128 -1 0 0 512.03 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="3" owner="0" type="0" pos="2.5 0 6.5" rot="1 0 0 0" scale="" transform="1 0 0 2.5 0 1 0 0 0 0 1 6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 -0.25 2" />
                            <Vertex pos="-0.25 -0.25 -2" />
                            <Vertex pos="-0.25 0.25 2" />
                            <Vertex pos="-0.25 0.25 -2" />
                            <Vertex pos="0.25 -0.25 1.5" />
                            <Vertex pos="0.25 -0.25 -1.5" />
                            <Vertex pos="0.25 0.25 1.5" />
                            <Vertex pos="0.25 0.25 -1.5" />
                        </Vertices>
                        <Face id="0" plane="-1 -0 -0 -0.25" album="Blasted" material="bm_beam_wood" texgens="0 -1 0 128 0 0 -1 -1792 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 0 0 -0.25" album="Blasted" material="bm_beam_wood" texgens="0 1 0 128 0 0 -1 -1792 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 -1 0 -0.25" album="Blasted" material="bm_beam_wood" texgens="1 0 0 127.98 0 0 -1 -1792 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 1 0 -0.25" album="Blasted" material="bm_beam_wood" texgens="-1 0 0 128.02 0 0 -1 -1792 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 -0 0.707106 -1.23744" album="Blasted" material="bm_beam_wood" texgens="0 1 0 128 1 0 0 127.98 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -1.23744" album="Blasted" material="bm_beam_wood" texgens="1 0 0 127.98 0 1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="4" owner="0" type="0" pos="1.25 0 3.75" rot="1 0 0 0" scale="" transform="1 0 0 1.25 0 1 0 0 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -0.25 -0.75" />
                            <Vertex pos="-1 -0.25 -1.25" />
                            <Vertex pos="-1 0.25 -0.75" />
                            <Vertex pos="-1 0.25 -1.25" />
                            <Vertex pos="1 -0.25 1.25" />
                            <Vertex pos="1 -0.25 0.75" />
                            <Vertex pos="1 0.25 1.25" />
                            <Vertex pos="1 0.25 0.75" />
                        </Vertices>
                        <Face id="0" plane="-1 -0 -0 -1" album="Blasted" material="bm_beam_wood" texgens="0 -1 0 128 0 0 -1 -2176 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 0 0 -1" album="Blasted" material="bm_beam_wood" texgens="0 1 0 128 0 0 -1 -2176 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 -1 0 -0.25" album="Blasted" material="bm_beam_wood" texgens="-1 0 1 127.96 0 0 -1 640 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 1 0 -0.25" album="Blasted" material="bm_beam_wood" texgens="-1 0 1 127.96 0 0 -1 640 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -0.176777" album="Blasted" material="bm_beam_wood" texgens="0 1 0 128 1 0 0 512.002 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -0.176777" album="Blasted" material="bm_beam_wood" texgens="0 1 0 128 -1 0 0 512.03 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="5" owner="0" type="0" pos="0.5 0 6.5" rot="1 0 0 0" scale="" transform="1 0 0 0.5 0 1 0 0 0 0 1 6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 -0.25 3.5" />
                            <Vertex pos="-0.25 -0.25 -3.5" />
                            <Vertex pos="-0.25 0.25 3.5" />
                            <Vertex pos="-0.25 0.25 -3.5" />
                            <Vertex pos="0.25 -0.25 3" />
                            <Vertex pos="0.25 -0.25 -3" />
                            <Vertex pos="0.25 0.25 3" />
                            <Vertex pos="0.25 0.25 -3" />
                        </Vertices>
                        <Face id="0" plane="-1 -0 -0 -0.25" album="Blasted" material="bm_wood" texgens="0 -1 0 128 0 0 -1 -1536 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 0 0 -0.25" album="Blasted" material="bm_wood" texgens="0 1 0 128 0 0 -1 -1536 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 -1 0 -0.25" album="Blasted" material="bm_wood" texgens="1 0 0 128.002 0 0 -1 -1536 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 1 0 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 127.998 0 0 -1 -1536 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 -0 0.707107 -2.2981" album="Blasted" material="bm_wood" texgens="-1 0 0 127.998 0 1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -2.2981" album="Blasted" material="bm_wood" texgens="1 0 0 128.002 0 1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="6" owner="0" type="0" pos="2 0 6.5" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 0 0 0 1 6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 -0.25 2" />
                            <Vertex pos="-0.25 -0.25 -2" />
                            <Vertex pos="-0.25 0.25 2" />
                            <Vertex pos="-0.25 0.25 -2" />
                            <Vertex pos="0.25 -0.25 1.5" />
                            <Vertex pos="0.25 -0.25 -1.5" />
                            <Vertex pos="0.25 0.25 1.5" />
                            <Vertex pos="0.25 0.25 -1.5" />
                        </Vertices>
                        <Face id="0" plane="-1 -0 -0 -0.25" album="Blasted" material="bm_wood" texgens="0 -1 0 128 0 0 -1 -1536 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 0 0 -0.25" album="Blasted" material="bm_wood" texgens="0 1 0 128 0 0 -1 -1536 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 -1 0 -0.25" album="Blasted" material="bm_wood" texgens="1 0 0 128.003 0 0 -1 -1536 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 1 0 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 128.02 0 0 -1 -1536 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 -0 0.707107 -1.23744" album="Blasted" material="bm_wood" texgens="-1 0 0 128.02 0 1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -1.23744" album="Blasted" material="bm_wood" texgens="1 0 0 128.003 0 1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="7" owner="0" type="0" pos="1.25 0 8" rot="1 0 0 0" scale="" transform="1 0 0 1.25 0 1 0 0 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.5 -0.125 1.5" />
                            <Vertex pos="-0.5 -0.125 -1.5" />
                            <Vertex pos="-0.5 0.125 1.5" />
                            <Vertex pos="-0.5 0.125 -1.5" />
                            <Vertex pos="0.5 -0.125 0.5" />
                            <Vertex pos="0.5 -0.125 -1.5" />
                            <Vertex pos="0.5 0.125 0.5" />
                            <Vertex pos="0.5 0.125 -1.5" />
                        </Vertices>
                        <Face id="0" plane="-1 -0 -0 -0.5" album="Blasted" material="bm_beam_wood" texgens="0 -1 0 128 0 0 -1 -2560 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 0 0 -0.5" album="Blasted" material="bm_beam_wood" texgens="0 1 0 128 0 0 -1 -2560 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 -1 0 -0.125" album="Blasted" material="bm_stripe_caution1" texgens="1 0 1 512 0 0 -1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 1 0 -0.125" album="Blasted" material="bm_stripe_caution1" texgens="-1 0 -1 256 0 0 -1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 -0 0.707107 -0.707106" album="Blasted" material="bm_beam_wood" texgens="-1 0 0 -0.00299072 0 1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1.5" album="Blasted" material="bm_beam_wood" texgens="1 0 0 256.003 0 1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="8" owner="0" type="0" pos="1.25 0 5" rot="1 0 0 0" scale="" transform="1 0 0 1.25 0 1 0 0 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.5 -0.125 1.5" />
                            <Vertex pos="-0.5 -0.125 -1.5" />
                            <Vertex pos="-0.5 0.125 1.5" />
                            <Vertex pos="-0.5 0.125 -1.5" />
                            <Vertex pos="0.5 -0.125 1.5" />
                            <Vertex pos="0.5 -0.125 -0.5" />
                            <Vertex pos="0.5 0.125 1.5" />
                            <Vertex pos="0.5 0.125 -0.5" />
                        </Vertices>
                        <Face id="0" plane="-1 -0 -0 -0.5" album="Blasted" material="bm_beam_wood" texgens="0 -1 0 128 0 0 -1 -2048 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 0 0 -0.5" album="Blasted" material="bm_beam_wood" texgens="0 1 0 128 0 0 -1 -2048 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 -1 0 -0.125" album="Blasted" material="bm_stripe_caution1" texgens="1 0 -1 512 0 0 -1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 1 0 -0.125" album="Blasted" material="bm_stripe_caution1" texgens="-1 0 1 256 0 0 -1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0 1 -1.5" album="Blasted" material="bm_beam_wood" texgens="-1 0 0 -0.00299072 0 1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -0.707107" album="Blasted" material="bm_beam_wood" texgens="1 0 0 256.003 0 1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="9" owner="0" type="0" pos="2 0 0" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 0 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -0.25 0.25" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="0.5 0.25 0.25" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="0.5 -0.25 -0.25" />
                            <Vertex pos="-0.5 -0.5 -0.5" />
                            <Vertex pos="0.5 0.25 -0.25" />
                            <Vertex pos="-0.5 0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.242536 0 0.970143 -0.363804" album="Blasted" material="bm_wood" texgens="0 -1 0 128 -1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0.242536 0 -0.970143 -0.363804" album="Blasted" material="bm_wood" texgens="0 1 0 128 -1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.242536 -0.970143 0 -0.363804" album="Blasted" material="bm_wood" texgens="0 0 -1 128 -1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.242536 0.970143 -0 -0.363804" album="Blasted" material="bm_wood" texgens="0 0 1 127.999 -1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="1 0 0 -0.5" album="Blasted" material="bm_wood" texgens="0 0 1 127.999 0 1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-1 -0 -0 -0.5" album="Blasted" material="bm_wood" texgens="0 0 -1 128 0 1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="10" owner="0" type="0" pos="6.5 0 0" rot="1 0 0 0" scale="" transform="1 0 0 6.5 0 1 0 0 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 -0.25 0.25" />
                            <Vertex pos="-4 -0.25 0.25" />
                            <Vertex pos="4 0.25 0.25" />
                            <Vertex pos="-4 0.25 0.25" />
                            <Vertex pos="4 -0.25 -0.25" />
                            <Vertex pos="-4 -0.25 -0.25" />
                            <Vertex pos="4 0.25 -0.25" />
                            <Vertex pos="-4 0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_beam_wood" texgens="0 -1 0 128 -1 0 0 -1792 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_beam_wood" texgens="0 1 0 128 -1 0 0 -1792 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 -1 0 -0.25" album="Blasted" material="bm_beam_wood" texgens="0 0 -1 128.001 -1 0 0 -1792 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 1 -0 -0.25" album="Blasted" material="bm_beam_wood" texgens="0 0 1 127.999 -1 0 0 -1792 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="1 0 0 -4" album="Blasted" material="bm_beam_wood" texgens="0 0 1 127.999 0 1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-1 -0 -0 -4" album="Blasted" material="bm_beam_wood" texgens="0 0 -1 128.001 0 1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="11" owner="0" type="0" pos="9.25 0 -1.25" rot="1 0 0 0" scale="" transform="1 0 0 9.25 0 1 0 0 0 0 1 -1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.25 -0.25 1" />
                            <Vertex pos="0.75 -0.25 1" />
                            <Vertex pos="1.25 0.25 1" />
                            <Vertex pos="0.75 0.25 1" />
                            <Vertex pos="-0.750001 -0.25 -1" />
                            <Vertex pos="-1.25 -0.25 -1" />
                            <Vertex pos="-0.750001 0.25 -1" />
                            <Vertex pos="-1.25 0.25 -1" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -1" album="Blasted" material="bm_beam_wood" texgens="0 -1 0 128 -1 0 0 -3200 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -1" album="Blasted" material="bm_beam_wood" texgens="0 1 0 128 -1 0 0 -3200 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 -1 -0 -0.25" album="Blasted" material="bm_beam_wood" texgens="1 0 -1 73601.7 -1 0 0 640 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 1 -0 -0.25" album="Blasted" material="bm_beam_wood" texgens="-1 0 1 128.34 -1 0 0 640 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 -0.707107 -0.176776" album="Blasted" material="bm_beam_wood" texgens="0 1 0 128 0 0 -1 512.002 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 0 0.707107 -0.176777" album="Blasted" material="bm_beam_wood" texgens="0 1 0 128 0 0 1 512.03 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="12" owner="0" type="0" pos="6.5 0 -2.5" rot="1 0 0 0" scale="" transform="1 0 0 6.5 0 1 0 0 0 0 1 -2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -0.25 0.25" />
                            <Vertex pos="-2 -0.25 0.25" />
                            <Vertex pos="2 0.25 0.25" />
                            <Vertex pos="-2 0.25 0.25" />
                            <Vertex pos="1.5 -0.25 -0.25" />
                            <Vertex pos="-1.5 -0.25 -0.25" />
                            <Vertex pos="1.5 0.25 -0.25" />
                            <Vertex pos="-1.5 0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_beam_wood" texgens="0 -1 0 128 -1 0 0 -1792 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_beam_wood" texgens="0 1 0 128 -1 0 0 -1792 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 -1 0 -0.25" album="Blasted" material="bm_beam_wood" texgens="0 0 -1 127.98 -1 0 0 -1792 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 1 -0 -0.25" album="Blasted" material="bm_beam_wood" texgens="0 0 1 128.02 -1 0 0 -1792 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707106 0 -0.707107 -1.23744" album="Blasted" material="bm_beam_wood" texgens="0 1 0 128 0 0 -1 127.98 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 -0 -0.707107 -1.23744" album="Blasted" material="bm_beam_wood" texgens="0 0 -1 127.98 0 1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="13" owner="0" type="0" pos="3.75 0 -1.25" rot="1 0 0 0" scale="" transform="1 0 0 3.75 0 1 0 0 0 0 1 -1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.75 -0.25 1" />
                            <Vertex pos="-1.25 -0.25 1" />
                            <Vertex pos="-0.75 0.25 1" />
                            <Vertex pos="-1.25 0.25 1" />
                            <Vertex pos="1.25 -0.25 -1" />
                            <Vertex pos="0.75 -0.25 -1" />
                            <Vertex pos="1.25 0.25 -1" />
                            <Vertex pos="0.75 0.25 -1" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -1" album="Blasted" material="bm_beam_wood" texgens="0 -1 0 128 -1 0 0 -2176 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -1" album="Blasted" material="bm_beam_wood" texgens="0 1 0 128 -1 0 0 -2176 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 -1 0 -0.25" album="Blasted" material="bm_beam_wood" texgens="1 0 1 127.96 -1 0 0 640 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 1 0 -0.25" album="Blasted" material="bm_beam_wood" texgens="1 0 1 127.96 -1 0 0 640 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 -0 0.707107 -0.176777" album="Blasted" material="bm_beam_wood" texgens="0 1 0 128 0 0 -1 512.001 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 -0 -0.707107 -0.176777" album="Blasted" material="bm_beam_wood" texgens="0 1 0 128 0 0 1 512.03 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="14" owner="0" type="0" pos="6.5 0 -0.5" rot="1 0 0 0" scale="" transform="1 0 0 6.5 0 1 0 0 0 0 1 -0.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.5 -0.25 0.25" />
                            <Vertex pos="-3.5 -0.25 0.25" />
                            <Vertex pos="3.5 0.25 0.25" />
                            <Vertex pos="-3.5 0.25 0.25" />
                            <Vertex pos="3 -0.25 -0.25" />
                            <Vertex pos="-3 -0.25 -0.25" />
                            <Vertex pos="3 0.25 -0.25" />
                            <Vertex pos="-3 0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_wood" texgens="0 -1 0 128 -1 0 0 -1536 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_wood" texgens="0 1 0 128 -1 0 0 -1536 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 -1 0 -0.25" album="Blasted" material="bm_wood" texgens="0 0 -1 128.002 -1 0 0 -1536 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 1 -0 -0.25" album="Blasted" material="bm_wood" texgens="0 0 1 127.998 -1 0 0 -1536 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 -0.707107 -2.2981" album="Blasted" material="bm_wood" texgens="0 0 1 127.998 0 1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 -0 -0.707107 -2.2981" album="Blasted" material="bm_wood" texgens="0 0 -1 128.002 0 1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="15" owner="0" type="0" pos="6.5 0 -2" rot="1 0 0 0" scale="" transform="1 0 0 6.5 0 1 0 0 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -0.25 0.25" />
                            <Vertex pos="-2 -0.25 0.25" />
                            <Vertex pos="2 0.25 0.25" />
                            <Vertex pos="-2 0.25 0.25" />
                            <Vertex pos="1.5 -0.25 -0.25" />
                            <Vertex pos="-1.5 -0.25 -0.25" />
                            <Vertex pos="1.5 0.25 -0.25" />
                            <Vertex pos="-1.5 0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_wood" texgens="0 -1 0 128 -1 0 0 -1536 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_wood" texgens="0 1 0 128 -1 0 0 -1536 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 -1 0 -0.25" album="Blasted" material="bm_wood" texgens="0 0 -1 128.003 -1 0 0 -1536 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 1 -0 -0.25" album="Blasted" material="bm_wood" texgens="0 0 1 128.02 -1 0 0 -1536 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 -0.707107 -1.23744" album="Blasted" material="bm_wood" texgens="0 0 1 128.02 0 1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 -0 -0.707107 -1.23744" album="Blasted" material="bm_wood" texgens="0 0 -1 128.003 0 1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="16" owner="0" type="0" pos="8 0 -1.25" rot="1 0 0 0" scale="" transform="1 0 0 8 0 1 0 0 0 0 1 -1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 -0.125 0.5" />
                            <Vertex pos="-1.5 -0.125 0.5" />
                            <Vertex pos="1.5 0.125 0.5" />
                            <Vertex pos="-1.5 0.125 0.5" />
                            <Vertex pos="0.5 -0.125 -0.5" />
                            <Vertex pos="-1.5 -0.125 -0.5" />
                            <Vertex pos="0.5 0.125 -0.5" />
                            <Vertex pos="-1.5 0.125 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.5" album="Blasted" material="bm_beam_wood" texgens="0 -1 0 128 -1 0 0 -2560 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.5" album="Blasted" material="bm_beam_wood" texgens="0 1 0 128 -1 0 0 -2560 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 -1 0 -0.125" album="Blasted" material="bm_stripe_caution1" texgens="1 0 -1 512 -1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 1 -0 -0.125" album="Blasted" material="bm_stripe_caution1" texgens="-1 0 1 256 -1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 -0.707107 -0.707106" album="Blasted" material="bm_beam_wood" texgens="0 0 1 -0.00299072 0 1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-1 -0 -0 -1.5" album="Blasted" material="bm_beam_wood" texgens="0 0 -1 256.003 0 1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="17" owner="0" type="0" pos="5 0 -1.25" rot="1 0 0 0" scale="" transform="1 0 0 5 0 1 0 0 0 0 1 -1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 -0.125 0.5" />
                            <Vertex pos="-1.5 -0.125 0.5" />
                            <Vertex pos="1.5 0.125 0.5" />
                            <Vertex pos="-1.5 0.125 0.5" />
                            <Vertex pos="1.5 -0.125 -0.5" />
                            <Vertex pos="-0.5 -0.125 -0.5" />
                            <Vertex pos="1.5 0.125 -0.5" />
                            <Vertex pos="-0.5 0.125 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.5" album="Blasted" material="bm_beam_wood" texgens="0 -1 0 128 -1 0 0 -2048 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.5" album="Blasted" material="bm_beam_wood" texgens="0 1 0 128 -1 0 0 -2048 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 -1 0 -0.125" album="Blasted" material="bm_stripe_caution1" texgens="-1 0 -1 512 -1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 1 -0 -0.125" album="Blasted" material="bm_stripe_caution1" texgens="1 0 1 256 -1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="1 0 0 -1.5" album="Blasted" material="bm_beam_wood" texgens="0 0 1 -0.00299072 0 1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 -0 -0.707107 -0.707107" album="Blasted" material="bm_beam_wood" texgens="0 0 -1 256.003 0 1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="18" owner="0" type="0" pos="0 0 -2" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 0 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 -0.25 -0.5" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="0.25 0.25 -0.5" />
                            <Vertex pos="0.5 0.5 0.5" />
                            <Vertex pos="-0.25 -0.25 -0.5" />
                            <Vertex pos="-0.5 -0.5 0.5" />
                            <Vertex pos="-0.25 0.25 -0.5" />
                            <Vertex pos="-0.5 0.5 0.5" />
                        </Vertices>
                        <Face id="0" plane="0.970143 0 -0.242536 -0.363804" album="Blasted" material="bm_wood" texgens="0 -1 0 128 0 0 1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.970143 0 -0.242536 -0.363804" album="Blasted" material="bm_wood" texgens="0 1 0 128 0 0 1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0 -0.970143 -0.242536 -0.363804" album="Blasted" material="bm_wood" texgens="-1 0 0 128.001 0 0 1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 0.970143 -0.242536 -0.363804" album="Blasted" material="bm_wood" texgens="1 0 0 128 0 0 1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 -1 -0.5" album="Blasted" material="bm_wood" texgens="1 0 0 128 0 1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 1 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 128.001 0 1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="19" owner="0" type="0" pos="0 0 -6.5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 0 0 0 1 -6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 -0.25 -4" />
                            <Vertex pos="0.25 -0.25 4" />
                            <Vertex pos="0.25 0.25 -4" />
                            <Vertex pos="0.25 0.25 4" />
                            <Vertex pos="-0.25 -0.25 -4" />
                            <Vertex pos="-0.25 -0.25 4" />
                            <Vertex pos="-0.25 0.25 -4" />
                            <Vertex pos="-0.25 0.25 4" />
                        </Vertices>
                        <Face id="0" plane="1 0 -0 -0.25" album="Blasted" material="bm_beam_wood" texgens="0 -1 0 128 0 0 1 -1792 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_beam_wood" texgens="0 1 0 128 0 0 1 -1792 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0 -1 -0 -0.25" album="Blasted" material="bm_beam_wood" texgens="-1 0 0 128.001 0 0 1 -1792 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 1 0 -0.25" album="Blasted" material="bm_beam_wood" texgens="1 0 0 127.998 0 0 1 -1792 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 -1 -4" album="Blasted" material="bm_beam_wood" texgens="1 0 0 127.998 0 1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 1 -4" album="Blasted" material="bm_beam_wood" texgens="-1 0 0 128.001 0 1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="20" owner="0" type="0" pos="-1.25 0 -9.25" rot="1 0 0 0" scale="" transform="1 0 0 -1.25 0 1 0 0 0 0 1 -9.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 -0.25 -1.25" />
                            <Vertex pos="1 -0.25 -0.75" />
                            <Vertex pos="1 0.25 -1.25" />
                            <Vertex pos="1 0.25 -0.75" />
                            <Vertex pos="-1 -0.25 0.750001" />
                            <Vertex pos="-1 -0.25 1.25" />
                            <Vertex pos="-1 0.25 0.750001" />
                            <Vertex pos="-1 0.25 1.25" />
                        </Vertices>
                        <Face id="0" plane="1 0 -0 -1" album="Blasted" material="bm_beam_wood" texgens="0 -1 0 128 0 0 1 -3200 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_beam_wood" texgens="0 1 0 128 0 0 1 -3200 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0 -1 -0 -0.25" album="Blasted" material="bm_beam_wood" texgens="-1 0 -1 73601.7 0 0 1 640 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0 1 0 -0.25" album="Blasted" material="bm_beam_wood" texgens="1 0 1 128.34 0 0 1 640 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 -0.707107 -0.176776" album="Blasted" material="bm_beam_wood" texgens="0 1 0 128 -1 0 0 512.002 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 0.707107 -0.176777" album="Blasted" material="bm_beam_wood" texgens="0 1 0 128 1 0 0 512.03 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="21" owner="0" type="0" pos="-2.5 0 -6.5" rot="1 0 0 0" scale="" transform="1 0 0 -2.5 0 1 0 0 0 0 1 -6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 -0.25 -2" />
                            <Vertex pos="0.25 -0.25 2" />
                            <Vertex pos="0.25 0.25 -2" />
                            <Vertex pos="0.25 0.25 2" />
                            <Vertex pos="-0.25 -0.25 -1.5" />
                            <Vertex pos="-0.25 -0.25 1.5" />
                            <Vertex pos="-0.25 0.25 -1.5" />
                            <Vertex pos="-0.25 0.25 1.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 -0 -0.25" album="Blasted" material="bm_beam_wood" texgens="0 -1 0 128 0 0 1 -1792 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_beam_wood" texgens="0 1 0 128 0 0 1 -1792 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 -1 -0 -0.25" album="Blasted" material="bm_beam_wood" texgens="-1 0 0 127.98 0 0 1 -1792 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0 1 0 -0.25" album="Blasted" material="bm_beam_wood" texgens="1 0 0 128.02 0 0 1 -1792 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 -0.707106 -1.23744" album="Blasted" material="bm_beam_wood" texgens="0 1 0 128 -1 0 0 127.98 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 0 0.707107 -1.23744" album="Blasted" material="bm_beam_wood" texgens="-1 0 0 127.98 0 1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="22" owner="0" type="0" pos="-1.25 0 -3.75" rot="1 0 0 0" scale="" transform="1 0 0 -1.25 0 1 0 0 0 0 1 -3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 -0.25 0.75" />
                            <Vertex pos="1 -0.25 1.25" />
                            <Vertex pos="1 0.25 0.75" />
                            <Vertex pos="1 0.25 1.25" />
                            <Vertex pos="-1 -0.25 -1.25" />
                            <Vertex pos="-1 -0.25 -0.75" />
                            <Vertex pos="-1 0.25 -1.25" />
                            <Vertex pos="-1 0.25 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 0 -0 -1" album="Blasted" material="bm_beam_wood" texgens="0 -1 0 128 0 0 1 -2176 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_beam_wood" texgens="0 1 0 128 0 0 1 -2176 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 -1 -0 -0.25" album="Blasted" material="bm_beam_wood" texgens="1 0 -1 127.96 0 0 1 640 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 1 0 -0.25" album="Blasted" material="bm_beam_wood" texgens="1 0 -1 127.96 0 0 1 640 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 -0.707107 -0.176777" album="Blasted" material="bm_beam_wood" texgens="0 1 0 128 -1 0 0 512.002 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 0 0.707107 -0.176777" album="Blasted" material="bm_beam_wood" texgens="0 1 0 128 1 0 0 512.03 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="23" owner="0" type="0" pos="-0.5 0 -6.5" rot="1 0 0 0" scale="" transform="1 0 0 -0.5 0 1 0 0 0 0 1 -6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 -0.25 -3.5" />
                            <Vertex pos="0.25 -0.25 3.5" />
                            <Vertex pos="0.25 0.25 -3.5" />
                            <Vertex pos="0.25 0.25 3.5" />
                            <Vertex pos="-0.25 -0.25 -3" />
                            <Vertex pos="-0.25 -0.25 3" />
                            <Vertex pos="-0.25 0.25 -3" />
                            <Vertex pos="-0.25 0.25 3" />
                        </Vertices>
                        <Face id="0" plane="1 0 -0 -0.25" album="Blasted" material="bm_wood" texgens="0 -1 0 128 0 0 1 -1536 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_wood" texgens="0 1 0 128 0 0 1 -1536 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 -1 -0 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 128.002 0 0 1 -1536 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0 1 0 -0.25" album="Blasted" material="bm_wood" texgens="1 0 0 127.998 0 0 1 -1536 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 -0.707107 -2.2981" album="Blasted" material="bm_wood" texgens="1 0 0 127.998 0 1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 0 0.707107 -2.2981" album="Blasted" material="bm_wood" texgens="-1 0 0 128.002 0 1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="24" owner="0" type="0" pos="-2 0 -6.5" rot="1 0 0 0" scale="" transform="1 0 0 -2 0 1 0 0 0 0 1 -6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 -0.25 -2" />
                            <Vertex pos="0.25 -0.25 2" />
                            <Vertex pos="0.25 0.25 -2" />
                            <Vertex pos="0.25 0.25 2" />
                            <Vertex pos="-0.25 -0.25 -1.5" />
                            <Vertex pos="-0.25 -0.25 1.5" />
                            <Vertex pos="-0.25 0.25 -1.5" />
                            <Vertex pos="-0.25 0.25 1.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 -0 -0.25" album="Blasted" material="bm_wood" texgens="0 -1 0 128 0 0 1 -1536 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_wood" texgens="0 1 0 128 0 0 1 -1536 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 -1 -0 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 128.003 0 0 1 -1536 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0 1 0 -0.25" album="Blasted" material="bm_wood" texgens="1 0 0 128.02 0 0 1 -1536 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 -0.707107 -1.23744" album="Blasted" material="bm_wood" texgens="1 0 0 128.02 0 1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 0 0.707107 -1.23744" album="Blasted" material="bm_wood" texgens="-1 0 0 128.003 0 1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="25" owner="0" type="0" pos="-1.25 0 -8" rot="1 0 0 0" scale="" transform="1 0 0 -1.25 0 1 0 0 0 0 1 -8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -0.125 -1.5" />
                            <Vertex pos="0.5 -0.125 1.5" />
                            <Vertex pos="0.5 0.125 -1.5" />
                            <Vertex pos="0.5 0.125 1.5" />
                            <Vertex pos="-0.5 -0.125 -0.5" />
                            <Vertex pos="-0.5 -0.125 1.5" />
                            <Vertex pos="-0.5 0.125 -0.5" />
                            <Vertex pos="-0.5 0.125 1.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 -0 -0.5" album="Blasted" material="bm_beam_wood" texgens="0 -1 0 128 0 0 1 -2560 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_beam_wood" texgens="0 1 0 128 0 0 1 -2560 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0 -1 -0 -0.125" album="Blasted" material="bm_stripe_caution1" texgens="-1 0 -1 512 0 0 1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0 1 0 -0.125" album="Blasted" material="bm_stripe_caution1" texgens="1 0 1 256 0 0 1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 -0.707107 -0.707106" album="Blasted" material="bm_beam_wood" texgens="1 0 0 -0.00299072 0 1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 1 -1.5" album="Blasted" material="bm_beam_wood" texgens="-1 0 0 256.003 0 1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="26" owner="0" type="0" pos="-1.25 0 -5" rot="1 0 0 0" scale="" transform="1 0 0 -1.25 0 1 0 0 0 0 1 -5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -0.125 -1.5" />
                            <Vertex pos="0.5 -0.125 1.5" />
                            <Vertex pos="0.5 0.125 -1.5" />
                            <Vertex pos="0.5 0.125 1.5" />
                            <Vertex pos="-0.5 -0.125 -1.5" />
                            <Vertex pos="-0.5 -0.125 0.5" />
                            <Vertex pos="-0.5 0.125 -1.5" />
                            <Vertex pos="-0.5 0.125 0.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 -0 -0.5" album="Blasted" material="bm_beam_wood" texgens="0 -1 0 128 0 0 1 -2048 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_beam_wood" texgens="0 1 0 128 0 0 1 -2048 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 -1 -0 -0.125" album="Blasted" material="bm_stripe_caution1" texgens="-1 0 1 512 0 0 1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 1 0 -0.125" album="Blasted" material="bm_stripe_caution1" texgens="1 0 -1 256 0 0 1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 -1 -1.5" album="Blasted" material="bm_beam_wood" texgens="1 0 0 -0.00299072 0 1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 0 0.707107 -0.707107" album="Blasted" material="bm_beam_wood" texgens="-1 0 0 256.003 0 1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="27" owner="0" type="0" pos="-2 0 0" rot="1 0 0 0" scale="" transform="1 0 0 -2 0 1 0 0 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.5 -0.25 -0.25" />
                            <Vertex pos="0.5 -0.5 -0.5" />
                            <Vertex pos="-0.5 0.25 -0.25" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="-0.5 -0.25 0.25" />
                            <Vertex pos="0.5 -0.5 0.5" />
                            <Vertex pos="-0.5 0.25 0.25" />
                            <Vertex pos="0.5 0.5 0.5" />
                        </Vertices>
                        <Face id="0" plane="-0.242536 -0 -0.970143 -0.363804" album="Blasted" material="bm_wood" texgens="0 -1 0 128 1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.242536 0 0.970143 -0.363804" album="Blasted" material="bm_wood" texgens="0 1 0 128 1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.242536 -0.970143 0 -0.363804" album="Blasted" material="bm_wood" texgens="0 0 1 128 1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.242536 0.970143 0 -0.363804" album="Blasted" material="bm_wood" texgens="0 0 -1 127.999 1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-1 0 0 -0.5" album="Blasted" material="bm_wood" texgens="0 0 -1 127.999 0 1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.5" album="Blasted" material="bm_wood" texgens="0 0 1 128 0 1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="28" owner="0" type="0" pos="-6.5 0 0" rot="1 0 0 0" scale="" transform="1 0 0 -6.5 0 1 0 0 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -0.25 -0.25" />
                            <Vertex pos="4 -0.25 -0.25" />
                            <Vertex pos="-4 0.25 -0.25" />
                            <Vertex pos="4 0.25 -0.25" />
                            <Vertex pos="-4 -0.25 0.25" />
                            <Vertex pos="4 -0.25 0.25" />
                            <Vertex pos="-4 0.25 0.25" />
                            <Vertex pos="4 0.25 0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 -1 -0.25" album="Blasted" material="bm_beam_wood" texgens="0 -1 0 128 1 0 0 -1792 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 1 -0.25" album="Blasted" material="bm_beam_wood" texgens="0 1 0 128 1 0 0 -1792 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 -1 0 -0.25" album="Blasted" material="bm_beam_wood" texgens="0 0 1 128.001 1 0 0 -1792 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0 1 0 -0.25" album="Blasted" material="bm_beam_wood" texgens="0 0 -1 127.999 1 0 0 -1792 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-1 0 0 -4" album="Blasted" material="bm_beam_wood" texgens="0 0 -1 127.999 0 1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -4" album="Blasted" material="bm_beam_wood" texgens="0 0 1 128.001 0 1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="29" owner="0" type="0" pos="-9.25 0 1.25" rot="1 0 0 0" scale="" transform="1 0 0 -9.25 0 1 0 0 0 0 1 1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.25 -0.25 -1" />
                            <Vertex pos="-0.75 -0.25 -1" />
                            <Vertex pos="-1.25 0.25 -1" />
                            <Vertex pos="-0.75 0.25 -1" />
                            <Vertex pos="0.750001 -0.25 1" />
                            <Vertex pos="1.25 -0.25 1" />
                            <Vertex pos="0.750001 0.25 1" />
                            <Vertex pos="1.25 0.25 1" />
                        </Vertices>
                        <Face id="0" plane="0 0 -1 -1" album="Blasted" material="bm_beam_wood" texgens="0 -1 0 128 1 0 0 -3200 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 1 -1" album="Blasted" material="bm_beam_wood" texgens="0 1 0 128 1 0 0 -3200 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 -1 0 -0.25" album="Blasted" material="bm_beam_wood" texgens="-1 0 1 73601.7 1 0 0 640 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0 1 0 -0.25" album="Blasted" material="bm_beam_wood" texgens="1 0 -1 128.34 1 0 0 640 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -0.176776" album="Blasted" material="bm_beam_wood" texgens="0 1 0 128 0 0 1 512.003 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -0.176777" album="Blasted" material="bm_beam_wood" texgens="0 1 0 128 0 0 -1 512.02 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="30" owner="0" type="0" pos="-6.5 0 2.5" rot="1 0 0 0" scale="" transform="1 0 0 -6.5 0 1 0 0 0 0 1 2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-2 -0.25 -0.25" />
                            <Vertex pos="2 -0.25 -0.25" />
                            <Vertex pos="-2 0.25 -0.25" />
                            <Vertex pos="2 0.25 -0.25" />
                            <Vertex pos="-1.5 -0.25 0.25" />
                            <Vertex pos="1.5 -0.25 0.25" />
                            <Vertex pos="-1.5 0.25 0.25" />
                            <Vertex pos="1.5 0.25 0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 -1 -0.25" album="Blasted" material="bm_beam_wood" texgens="0 -1 0 128 1 0 0 -1792 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 1 -0.25" album="Blasted" material="bm_beam_wood" texgens="0 1 0 128 1 0 0 -1792 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 -1 0 -0.25" album="Blasted" material="bm_beam_wood" texgens="0 0 1 127.98 1 0 0 -1792 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0 1 0 -0.25" album="Blasted" material="bm_beam_wood" texgens="0 0 -1 128.02 1 0 0 -1792 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707106 0 0.707107 -1.23744" album="Blasted" material="bm_beam_wood" texgens="0 1 0 128 0 0 1 127.98 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 0.707107 -1.23744" album="Blasted" material="bm_beam_wood" texgens="0 0 1 127.98 0 1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="31" owner="0" type="0" pos="-3.75 0 1.25" rot="1 0 0 0" scale="" transform="1 0 0 -3.75 0 1 0 0 0 0 1 1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.75 -0.25 -1" />
                            <Vertex pos="1.25 -0.25 -1" />
                            <Vertex pos="0.75 0.25 -1" />
                            <Vertex pos="1.25 0.25 -1" />
                            <Vertex pos="-1.25 -0.25 1" />
                            <Vertex pos="-0.75 -0.25 1" />
                            <Vertex pos="-1.25 0.25 1" />
                            <Vertex pos="-0.75 0.25 1" />
                        </Vertices>
                        <Face id="0" plane="0 0 -1 -1" album="Blasted" material="bm_beam_wood" texgens="0 -1 0 128 1 0 0 -2176 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 1 -1" album="Blasted" material="bm_beam_wood" texgens="0 1 0 128 1 0 0 -2176 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 -1 0 -0.25" album="Blasted" material="bm_beam_wood" texgens="-1 0 -1 127.96 1 0 0 640 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0 1 0 -0.25" album="Blasted" material="bm_beam_wood" texgens="-1 0 -1 127.96 1 0 0 640 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 -0.707107 -0.176777" album="Blasted" material="bm_beam_wood" texgens="0 1 0 128 0 0 1 512.002 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 0.707107 -0.176777" album="Blasted" material="bm_beam_wood" texgens="0 1 0 128 0 0 -1 512.03 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="32" owner="0" type="0" pos="-6.5 0 0.5" rot="1 0 0 0" scale="" transform="1 0 0 -6.5 0 1 0 0 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-3.5 -0.25 -0.25" />
                            <Vertex pos="3.5 -0.25 -0.25" />
                            <Vertex pos="-3.5 0.25 -0.25" />
                            <Vertex pos="3.5 0.25 -0.25" />
                            <Vertex pos="-3 -0.25 0.25" />
                            <Vertex pos="3 -0.25 0.25" />
                            <Vertex pos="-3 0.25 0.25" />
                            <Vertex pos="3 0.25 0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 -1 -0.25" album="Blasted" material="bm_wood" texgens="0 -1 0 128 1 0 0 -1536 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 1 -0.25" album="Blasted" material="bm_wood" texgens="0 1 0 128 1 0 0 -1536 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 -1 0 -0.25" album="Blasted" material="bm_wood" texgens="0 0 1 128.003 1 0 0 -1536 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0 1 0 -0.25" album="Blasted" material="bm_wood" texgens="0 0 -1 127.997 1 0 0 -1536 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -2.2981" album="Blasted" material="bm_wood" texgens="0 0 -1 127.997 0 1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 0.707107 -2.2981" album="Blasted" material="bm_wood" texgens="0 0 1 128.003 0 1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="33" owner="0" type="0" pos="-6.5 0 2" rot="1 0 0 0" scale="" transform="1 0 0 -6.5 0 1 0 0 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-2 -0.25 -0.25" />
                            <Vertex pos="2 -0.25 -0.25" />
                            <Vertex pos="-2 0.25 -0.25" />
                            <Vertex pos="2 0.25 -0.25" />
                            <Vertex pos="-1.5 -0.25 0.25" />
                            <Vertex pos="1.5 -0.25 0.25" />
                            <Vertex pos="-1.5 0.25 0.25" />
                            <Vertex pos="1.5 0.25 0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 -1 -0.25" album="Blasted" material="bm_wood" texgens="0 -1 0 128 1 0 0 -1536 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 1 -0.25" album="Blasted" material="bm_wood" texgens="0 1 0 128 1 0 0 -1536 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 -1 0 -0.25" album="Blasted" material="bm_wood" texgens="0 0 1 128.003 1 0 0 -1536 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0 1 0 -0.25" album="Blasted" material="bm_wood" texgens="0 0 -1 128.02 1 0 0 -1536 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -1.23744" album="Blasted" material="bm_wood" texgens="0 0 -1 128.02 0 1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 0.707107 -1.23744" album="Blasted" material="bm_wood" texgens="0 0 1 128.003 0 1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="34" owner="0" type="0" pos="-8 0 1.25" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 0 0 0 1 1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.5 -0.125 -0.5" />
                            <Vertex pos="1.5 -0.125 -0.5" />
                            <Vertex pos="-1.5 0.125 -0.5" />
                            <Vertex pos="1.5 0.125 -0.5" />
                            <Vertex pos="-0.5 -0.125 0.5" />
                            <Vertex pos="1.5 -0.125 0.5" />
                            <Vertex pos="-0.5 0.125 0.5" />
                            <Vertex pos="1.5 0.125 0.5" />
                        </Vertices>
                        <Face id="0" plane="0 0 -1 -0.5" album="Blasted" material="bm_beam_wood" texgens="0 -1 0 128 1 0 0 -2560 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 1 -0.5" album="Blasted" material="bm_beam_wood" texgens="0 1 0 128 1 0 0 -2560 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 -1 0 -0.125" album="Blasted" material="bm_stripe_caution1" texgens="-1 0 1 512 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0 1 0 -0.125" album="Blasted" material="bm_stripe_caution1" texgens="1 0 -1 256 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -0.707106" album="Blasted" material="bm_beam_wood" texgens="0 0 -1 -0.00299072 0 1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1.5" album="Blasted" material="bm_beam_wood" texgens="0 0 1 256.003 0 1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="35" owner="0" type="0" pos="-5 0 1.25" rot="1 0 0 0" scale="" transform="1 0 0 -5 0 1 0 0 0 0 1 1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.5 -0.125 -0.5" />
                            <Vertex pos="1.5 -0.125 -0.5" />
                            <Vertex pos="-1.5 0.125 -0.5" />
                            <Vertex pos="1.5 0.125 -0.5" />
                            <Vertex pos="-1.5 -0.125 0.5" />
                            <Vertex pos="0.5 -0.125 0.5" />
                            <Vertex pos="-1.5 0.125 0.5" />
                            <Vertex pos="0.5 0.125 0.5" />
                        </Vertices>
                        <Face id="0" plane="0 0 -1 -0.5" album="Blasted" material="bm_beam_wood" texgens="0 -1 0 128 1 0 0 -2048 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 1 -0.5" album="Blasted" material="bm_beam_wood" texgens="0 1 0 128 1 0 0 -2048 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 -1 0 -0.125" album="Blasted" material="bm_stripe_caution1" texgens="1 0 1 512 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0 1 0 -0.125" album="Blasted" material="bm_stripe_caution1" texgens="-1 0 -1 256 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-1 0 0 -1.5" album="Blasted" material="bm_beam_wood" texgens="0 0 -1 -0.00299072 0 1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 0.707107 -0.707107" album="Blasted" material="bm_beam_wood" texgens="0 0 1 256.003 0 1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="36" owner="0" type="0" pos="0 0 0" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 0 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="35" nextVertexID="65">
                        <Vertices>
                            <Vertex pos="1.96875 0.5 0.390624" />
                            <Vertex pos="1.96875 -0.5 0.390624" />
                            <Vertex pos="2 0.5 0" />
                            <Vertex pos="2 -0.5 0" />
                            <Vertex pos="1.84375 0.5 0.765625" />
                            <Vertex pos="1.84375 -0.5 0.765625" />
                            <Vertex pos="1.65625 0.5 1.10937" />
                            <Vertex pos="1.65625 -0.5 1.10937" />
                            <Vertex pos="1.42187 0.5 1.42187" />
                            <Vertex pos="1.42187 -0.5 1.42187" />
                            <Vertex pos="1.10937 0.5 1.65625" />
                            <Vertex pos="1.10937 -0.5 1.65625" />
                            <Vertex pos="0.765626 0.5 1.84375" />
                            <Vertex pos="0.765626 -0.5 1.84375" />
                            <Vertex pos="0.390623 0.5 1.96875" />
                            <Vertex pos="0.390623 -0.5 1.96875" />
                            <Vertex pos="0 0.5 2" />
                            <Vertex pos="0 -0.5 2" />
                            <Vertex pos="-0.390624 0.5 1.96875" />
                            <Vertex pos="-0.390624 -0.5 1.96875" />
                            <Vertex pos="-0.765625 0.5 1.84375" />
                            <Vertex pos="-0.765625 -0.5 1.84375" />
                            <Vertex pos="-1.10937 0.5 1.65625" />
                            <Vertex pos="-1.10937 -0.5 1.65625" />
                            <Vertex pos="-1.42187 0.5 1.42187" />
                            <Vertex pos="-1.42187 -0.5 1.42187" />
                            <Vertex pos="-1.65625 0.5 1.10937" />
                            <Vertex pos="-1.65625 -0.5 1.10937" />
                            <Vertex pos="-1.84375 0.5 0.765626" />
                            <Vertex pos="-1.84375 -0.5 0.765626" />
                            <Vertex pos="-1.96875 0.5 0.390623" />
                            <Vertex pos="-1.96875 -0.5 0.390623" />
                            <Vertex pos="-2 0.5 0" />
                            <Vertex pos="-2 -0.5 0" />
                            <Vertex pos="-1.96875 0.5 -0.390624" />
                            <Vertex pos="-1.96875 -0.5 -0.390624" />
                            <Vertex pos="-1.84375 0.5 -0.765625" />
                            <Vertex pos="-1.84375 -0.5 -0.765625" />
                            <Vertex pos="-1.65625 0.5 -1.10937" />
                            <Vertex pos="-1.65625 -0.5 -1.10937" />
                            <Vertex pos="-1.42187 0.5 -1.42187" />
                            <Vertex pos="-1.42187 -0.5 -1.42187" />
                            <Vertex pos="-1.10937 0.5 -1.65625" />
                            <Vertex pos="-1.10937 -0.5 -1.65625" />
                            <Vertex pos="-0.765626 0.5 -1.84375" />
                            <Vertex pos="-0.765626 -0.5 -1.84375" />
                            <Vertex pos="-0.390623 0.5 -1.96875" />
                            <Vertex pos="-0.390623 -0.5 -1.96875" />
                            <Vertex pos="0 0.5 -2" />
                            <Vertex pos="0 -0.5 -2" />
                            <Vertex pos="0.390624 0.5 -1.96875" />
                            <Vertex pos="0.390624 -0.5 -1.96875" />
                            <Vertex pos="0.765625 0.5 -1.84375" />
                            <Vertex pos="0.765625 -0.5 -1.84375" />
                            <Vertex pos="1.10937 0.5 -1.65625" />
                            <Vertex pos="1.10937 -0.5 -1.65625" />
                            <Vertex pos="1.42187 0.5 -1.42187" />
                            <Vertex pos="1.42187 -0.5 -1.42187" />
                            <Vertex pos="1.65625 0.5 -1.10937" />
                            <Vertex pos="1.65625 -0.5 -1.10937" />
                            <Vertex pos="1.84375 0.5 -0.765626" />
                            <Vertex pos="1.84375 -0.5 -0.765626" />
                            <Vertex pos="1.96875 0.5 -0.390623" />
                            <Vertex pos="1.96875 -0.5 -0.390623" />
                        </Vertices>
                        <Face id="0" plane="0.996815 -0 0.0797452 -1.99363" album="Blasted" material="bm_grid_blank2" texgens="0 1 0 128 0.199444 0 -0.979909 125.319 0 0.125 0.0976758" texRot="0" texScale="0.125 0.0976758" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.948683 0 0.316228 -1.99125" album="Blasted" material="bm_grid_blank2" texgens="0 1 0 128 0.199444 0 -0.979909 125.319 0 0.125 0.0976758" texRot="0" texScale="0.125 0.0976758" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0.877895 0 0.478852 -1.98524" album="Blasted" material="bm_grid_blank2" texgens="0 1 0 128 0.54083 0 -0.841132 140.113 0 0.125 0.0975194" texRot="0" texScale="0.125 0.0975194" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="0.8 0 0.6 -1.99062" album="Blasted" material="bm_grid_blank2" texgens="0 1 0 128 0.54083 0 -0.841132 140.113 0 0.125 0.0975194" texRot="0" texScale="0.125 0.0975194" texDiv="256 256">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="0.6 0 0.8 -1.99062" album="Blasted" material="bm_grid_blank2" texgens="0.841132 0 -0.54083 115.887 0 -1 0 128 0 0.0975193 0.125" texRot="0" texScale="0.0975193 0.125" texDiv="256 256">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="0.478852 0 0.877895 -1.98524" album="Blasted" material="bm_grid_blank2" texgens="0.841132 0 -0.54083 115.887 0 -1 0 128 0 0.0975193 0.125" texRot="0" texScale="0.0975193 0.125" texDiv="256 256">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="0.316228 0 0.948683 -1.99125" album="Blasted" material="bm_grid_blank2" texgens="0.979909 0 -0.199444 130.681 0 -1 0 128 0 0.0976759 0.125" texRot="0" texScale="0.0976759 0.125" texDiv="256 256">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="0.0797453 0 0.996815 -1.99363" album="Blasted" material="bm_grid_blank2" texgens="0.979909 0 -0.199444 130.681 0 -1 0 128 0 0.0976759 0.125" texRot="0" texScale="0.0976759 0.125" texDiv="256 256">
                            <Indices indices=" 17 16 14 15" />
                        </Face>
                        <Face id="8" plane="-0.0797452 0 0.996815 -1.99363" album="Blasted" material="bm_grid_blank2" texgens="0.926215 0 0.376996 4.68219 0 -1 0 128 0 0.0960049 0.125" texRot="0" texScale="0.0960049 0.125" texDiv="256 256">
                            <Indices indices=" 19 18 16 17" />
                        </Face>
                        <Face id="9" plane="-0.316228 0 0.948683 -1.99125" album="Blasted" material="bm_grid_blank2" texgens="0.926215 0 0.376996 4.68219 0 -1 0 128 0 0.0960049 0.125" texRot="0" texScale="0.0960049 0.125" texDiv="256 256">
                            <Indices indices=" 21 20 18 19" />
                        </Face>
                        <Face id="10" plane="-0.478852 0 0.877895 -1.98524" album="Blasted" material="bm_grid_blank2" texgens="0.926215 0 0.376996 260.689 0 -1 0 128 0 0.0958592 0.125" texRot="0" texScale="0.0958592 0.125" texDiv="256 256">
                            <Indices indices=" 23 22 20 21" />
                        </Face>
                        <Face id="11" plane="-0.6 0 0.8 -1.99062" album="Blasted" material="bm_grid_blank2" texgens="0.926215 0 0.376996 260.689 0 -1 0 128 0 0.0958592 0.125" texRot="0" texScale="0.0958592 0.125" texDiv="256 256">
                            <Indices indices=" 25 24 22 23" />
                        </Face>
                        <Face id="12" plane="-0.8 0 0.6 -1.99062" album="Blasted" material="bm_grid_blank2" texgens="0 -1 0 128 -0.54083 0 -0.841132 140.113 0 0.125 0.0975193" texRot="0" texScale="0.125 0.0975193" texDiv="256 256">
                            <Indices indices=" 27 26 24 25" />
                        </Face>
                        <Face id="13" plane="-0.877895 0 0.478852 -1.98524" album="Blasted" material="bm_grid_blank2" texgens="0 -1 0 128 -0.54083 0 -0.841132 140.113 0 0.125 0.0975193" texRot="0" texScale="0.125 0.0975193" texDiv="256 256">
                            <Indices indices=" 29 28 26 27" />
                        </Face>
                        <Face id="14" plane="-0.948683 0 0.316228 -1.99125" album="Blasted" material="bm_grid_blank2" texgens="0 -1 0 128 -0.199444 0 -0.979909 125.319 0 0.125 0.0976759" texRot="0" texScale="0.125 0.0976759" texDiv="256 256">
                            <Indices indices=" 31 30 28 29" />
                        </Face>
                        <Face id="15" plane="-0.996815 0 0.0797453 -1.99363" album="Blasted" material="bm_grid_blank2" texgens="0 -1 0 128 -0.199444 0 -0.979909 125.319 0 0.125 0.0976759" texRot="0" texScale="0.125 0.0976759" texDiv="256 256">
                            <Indices indices=" 33 32 30 31" />
                        </Face>
                        <Face id="16" plane="-0.996815 -0 -0.0797452 -1.99363" album="Blasted" material="bm_grid_blank2" texgens="0 -1 0 128 0.199444 0 -0.979909 130.681 0 0.125 0.0976758" texRot="0" texScale="0.125 0.0976758" texDiv="256 256">
                            <Indices indices=" 35 34 32 33" />
                        </Face>
                        <Face id="17" plane="-0.948683 -0 -0.316228 -1.99125" album="Blasted" material="bm_grid_blank2" texgens="0 -1 0 128 0.199444 0 -0.979909 130.681 0 0.125 0.0976758" texRot="0" texScale="0.125 0.0976758" texDiv="256 256">
                            <Indices indices=" 37 36 34 35" />
                        </Face>
                        <Face id="18" plane="-0.877895 -0 -0.478852 -1.98524" album="Blasted" material="bm_grid_blank2" texgens="0 -1 0 128 0.54083 0 -0.841132 115.887 0 0.125 0.0975194" texRot="0" texScale="0.125 0.0975194" texDiv="256 256">
                            <Indices indices=" 39 38 36 37" />
                        </Face>
                        <Face id="19" plane="-0.8 -0 -0.6 -1.99062" album="Blasted" material="bm_grid_blank2" texgens="0 -1 0 128 0.54083 0 -0.841132 115.887 0 0.125 0.0975194" texRot="0" texScale="0.125 0.0975194" texDiv="256 256">
                            <Indices indices=" 41 40 38 39" />
                        </Face>
                        <Face id="20" plane="-0.6 -0 -0.8 -1.99062" album="Blasted" material="bm_grid_blank2" texgens="-0.841132 0 0.54083 115.887 0 -1 0 128 0 0.0975193 0.125" texRot="0" texScale="0.0975193 0.125" texDiv="256 256">
                            <Indices indices=" 43 42 40 41" />
                        </Face>
                        <Face id="21" plane="-0.478852 -0 -0.877895 -1.98524" album="Blasted" material="bm_grid_blank2" texgens="-0.841132 0 0.54083 115.887 0 -1 0 128 0 0.0975193 0.125" texRot="0" texScale="0.0975193 0.125" texDiv="256 256">
                            <Indices indices=" 45 44 42 43" />
                        </Face>
                        <Face id="22" plane="-0.316228 -0 -0.948683 -1.99125" album="Blasted" material="bm_grid_blank2" texgens="-0.979909 0 0.199444 130.681 0 -1 0 128 0 0.0976759 0.125" texRot="0" texScale="0.0976759 0.125" texDiv="256 256">
                            <Indices indices=" 47 46 44 45" />
                        </Face>
                        <Face id="23" plane="-0.0797453 -0 -0.996815 -1.99363" album="Blasted" material="bm_grid_blank2" texgens="-0.979909 0 0.199444 130.681 0 -1 0 128 0 0.0976759 0.125" texRot="0" texScale="0.0976759 0.125" texDiv="256 256">
                            <Indices indices=" 49 48 46 47" />
                        </Face>
                        <Face id="24" plane="0.0797452 0 -0.996815 -1.99363" album="Blasted" material="bm_grid_blank2" texgens="-0.979909 0 -0.199444 125.319 0 -1 0 128 0 0.0976758 0.125" texRot="0" texScale="0.0976758 0.125" texDiv="256 256">
                            <Indices indices=" 51 50 48 49" />
                        </Face>
                        <Face id="25" plane="0.316228 0 -0.948683 -1.99125" album="Blasted" material="bm_grid_blank2" texgens="-0.979909 0 -0.199444 125.319 0 -1 0 128 0 0.0976758 0.125" texRot="0" texScale="0.0976758 0.125" texDiv="256 256">
                            <Indices indices=" 53 52 50 51" />
                        </Face>
                        <Face id="26" plane="0.478852 0 -0.877895 -1.98524" album="Blasted" material="bm_grid_blank2" texgens="-0.841132 0 -0.54083 140.113 0 -1 0 128 0 0.0975194 0.125" texRot="0" texScale="0.0975194 0.125" texDiv="256 256">
                            <Indices indices=" 55 54 52 53" />
                        </Face>
                        <Face id="27" plane="0.6 0 -0.8 -1.99062" album="Blasted" material="bm_grid_blank2" texgens="-0.841132 0 -0.54083 140.113 0 -1 0 128 0 0.0975194 0.125" texRot="0" texScale="0.0975194 0.125" texDiv="256 256">
                            <Indices indices=" 57 56 54 55" />
                        </Face>
                        <Face id="28" plane="0.8 0 -0.6 -1.99062" album="Blasted" material="bm_grid_blank2" texgens="0 1 0 128 -0.54083 0 -0.841132 115.887 0 0.125 0.0975193" texRot="0" texScale="0.125 0.0975193" texDiv="256 256">
                            <Indices indices=" 59 58 56 57" />
                        </Face>
                        <Face id="29" plane="0.877895 0 -0.478852 -1.98524" album="Blasted" material="bm_grid_blank2" texgens="0 1 0 128 -0.54083 0 -0.841132 115.887 0 0.125 0.0975193" texRot="0" texScale="0.125 0.0975193" texDiv="256 256">
                            <Indices indices=" 61 60 58 59" />
                        </Face>
                        <Face id="30" plane="0.948683 0 -0.316228 -1.99125" album="Blasted" material="bm_grid_blank2" texgens="0 1 0 128 -0.199444 0 -0.979909 130.681 0 0.125 0.0976759" texRot="0" texScale="0.125 0.0976759" texDiv="256 256">
                            <Indices indices=" 63 62 60 61" />
                        </Face>
                        <Face id="31" plane="0.996815 0 -0.0797453 -1.99363" album="Blasted" material="bm_grid_blank2" texgens="0 1 0 128 -0.199444 0 -0.979909 130.681 0 0.125 0.0976759" texRot="0" texScale="0.125 0.0976759" texDiv="256 256">
                            <Indices indices=" 63 3 2 62" />
                        </Face>
                        <Face id="32" plane="0 1 0 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 62 2 0 4 6 8 10 12 14 16 18 20 22 24 26 28 30 32 34 36 38 40 42 44 46 48 50 52 54 56 58 60" />
                        </Face>
                        <Face id="33" plane="-0 -1 0 -0.5" album="Blasted" material="bm_wood" texgens="1 0 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 63 61 59 57 55 53 51 49 47 45 43 41 39 37 35 33 31 29 27 25 23 21 19 17 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="37" owner="0" type="0" pos="0 -0.75 0" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -0.75 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="35" nextVertexID="65">
                        <Vertices>
                            <Vertex pos="2.45312 0.25 0.484378" />
                            <Vertex pos="2.45312 -0.25 0.484378" />
                            <Vertex pos="2.5 0.25 0" />
                            <Vertex pos="2.5 -0.25 0" />
                            <Vertex pos="2.3125 0.25 0.953122" />
                            <Vertex pos="2.3125 -0.25 0.953122" />
                            <Vertex pos="2.07812 0.25 1.39062" />
                            <Vertex pos="2.07812 -0.25 1.39062" />
                            <Vertex pos="1.76562 0.25 1.76562" />
                            <Vertex pos="1.76562 -0.25 1.76562" />
                            <Vertex pos="1.39062 0.25 2.07812" />
                            <Vertex pos="1.39062 -0.25 2.07812" />
                            <Vertex pos="0.953122 0.25 2.3125" />
                            <Vertex pos="0.953122 -0.25 2.3125" />
                            <Vertex pos="0.484378 0.25 2.45312" />
                            <Vertex pos="0.484378 -0.25 2.45312" />
                            <Vertex pos="0 0.25 2.5" />
                            <Vertex pos="0 -0.25 2.5" />
                            <Vertex pos="-0.484378 0.25 2.45312" />
                            <Vertex pos="-0.484378 -0.25 2.45312" />
                            <Vertex pos="-0.953122 0.25 2.3125" />
                            <Vertex pos="-0.953122 -0.25 2.3125" />
                            <Vertex pos="-1.39062 0.25 2.07812" />
                            <Vertex pos="-1.39062 -0.25 2.07812" />
                            <Vertex pos="-1.76562 0.25 1.76562" />
                            <Vertex pos="-1.76562 -0.25 1.76562" />
                            <Vertex pos="-2.07812 0.25 1.39062" />
                            <Vertex pos="-2.07812 -0.25 1.39062" />
                            <Vertex pos="-2.3125 0.25 0.953122" />
                            <Vertex pos="-2.3125 -0.25 0.953122" />
                            <Vertex pos="-2.45312 0.25 0.484378" />
                            <Vertex pos="-2.45312 -0.25 0.484378" />
                            <Vertex pos="-2.5 0.25 0" />
                            <Vertex pos="-2.5 -0.25 0" />
                            <Vertex pos="-2.45312 0.25 -0.484378" />
                            <Vertex pos="-2.45312 -0.25 -0.484378" />
                            <Vertex pos="-2.3125 0.25 -0.953122" />
                            <Vertex pos="-2.3125 -0.25 -0.953122" />
                            <Vertex pos="-2.07812 0.25 -1.39062" />
                            <Vertex pos="-2.07812 -0.25 -1.39062" />
                            <Vertex pos="-1.76562 0.25 -1.76562" />
                            <Vertex pos="-1.76562 -0.25 -1.76562" />
                            <Vertex pos="-1.39062 0.25 -2.07812" />
                            <Vertex pos="-1.39062 -0.25 -2.07812" />
                            <Vertex pos="-0.953122 0.25 -2.3125" />
                            <Vertex pos="-0.953122 -0.25 -2.3125" />
                            <Vertex pos="-0.484378 0.25 -2.45312" />
                            <Vertex pos="-0.484378 -0.25 -2.45312" />
                            <Vertex pos="0 0.25 -2.5" />
                            <Vertex pos="0 -0.25 -2.5" />
                            <Vertex pos="0.484378 0.25 -2.45312" />
                            <Vertex pos="0.484378 -0.25 -2.45312" />
                            <Vertex pos="0.953122 0.25 -2.3125" />
                            <Vertex pos="0.953122 -0.25 -2.3125" />
                            <Vertex pos="1.39062 0.25 -2.07812" />
                            <Vertex pos="1.39062 -0.25 -2.07812" />
                            <Vertex pos="1.76562 0.25 -1.76562" />
                            <Vertex pos="1.76562 -0.25 -1.76562" />
                            <Vertex pos="2.07812 0.25 -1.39062" />
                            <Vertex pos="2.07812 -0.25 -1.39062" />
                            <Vertex pos="2.3125 0.25 -0.953122" />
                            <Vertex pos="2.3125 -0.25 -0.953122" />
                            <Vertex pos="2.45312 0.25 -0.484378" />
                            <Vertex pos="2.45312 -0.25 -0.484378" />
                        </Vertices>
                        <Face id="0" plane="0.99535 -0 0.0963242 -2.48837" album="Blasted" material="bm_beam_wood" texgens="-0.0980232 0 0.995184 128 0 1 0 127.086 90 0.0625001 0.0608299" texRot="90" texScale="0.0625001 0.0608299" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.957826 0 0.287348 -2.48885" album="Blasted" material="bm_beam_wood" texgens="-0.290278 0 0.956942 128 0 1 0 125.972 90 0.0625 0.0611727" texRot="90" texScale="0.0625 0.0611727" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0.88148 0 0.472222 -2.48851" album="Blasted" material="bm_beam_wood" texgens="-0.471401 0 0.881919 128 0 1 0 127.291 90 0.0625 0.0620409" texRot="90" texScale="0.0625 0.0620409" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="0.768221 0 0.640184 -2.48672" album="Blasted" material="bm_beam_wood" texgens="-0.634386 0 0.773017 128 0 1 0 128.371 90 0.0625 0.0610158" texRot="90" texScale="0.0625 0.0610158" texDiv="256 256">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="0.640184 0 0.768221 -2.48672" album="Blasted" material="bm_beam_wood" texgens="-0.773017 0 0.634386 128 0 1 0 127.629 90 0.0625001 0.0610159" texRot="90" texScale="0.0625001 0.0610159" texDiv="256 256">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="0.472222 0 0.88148 -2.48851" album="Blasted" material="bm_beam_wood" texgens="-0.881922 0 0.471396 128 0 1 0 128.702 90 0.0625 0.062041" texRot="90" texScale="0.0625 0.062041" texDiv="256 256">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="0.287348 0 0.957826 -2.48885" album="Blasted" material="bm_beam_wood" texgens="-0.956943 0 0.290276 128 0 1 0 130.025 90 0.0625 0.0611727" texRot="90" texScale="0.0625 0.0611727" texDiv="256 256">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="0.0963242 0 0.99535 -2.48837" album="Blasted" material="bm_beam_wood" texgens="-0.995184 0 0.0980231 128 0 1 0 128.914 90 0.0625001 0.06083" texRot="90" texScale="0.0625001 0.06083" texDiv="256 256">
                            <Indices indices=" 17 16 14 15" />
                        </Face>
                        <Face id="8" plane="-0.0963242 0 0.99535 -2.48837" album="Blasted" material="bm_beam_wood" texgens="-0.995184 0 -0.0980232 128 0 1 0 127.086 90 0.0625001 0.0608299" texRot="90" texScale="0.0625001 0.0608299" texDiv="256 256">
                            <Indices indices=" 19 18 16 17" />
                        </Face>
                        <Face id="9" plane="-0.287348 0 0.957826 -2.48885" album="Blasted" material="bm_beam_wood" texgens="-0.956937 0 -0.290295 128 0 1 0 125.949 90 0.0625 0.0611727" texRot="90" texScale="0.0625 0.0611727" texDiv="256 256">
                            <Indices indices=" 21 20 18 19" />
                        </Face>
                        <Face id="10" plane="-0.472222 0 0.88148 -2.48851" album="Blasted" material="bm_beam_wood" texgens="-0.881927 0 -0.471387 128 0 1 0 127.311 90 0.0625 0.0620409" texRot="90" texScale="0.0625 0.0620409" texDiv="256 256">
                            <Indices indices=" 23 22 20 21" />
                        </Face>
                        <Face id="11" plane="-0.640184 0 0.768221 -2.48672" album="Blasted" material="bm_beam_wood" texgens="-0.773007 0 -0.634398 128 0 1 0 128.35 90 0.0625 0.0610159" texRot="90" texScale="0.0625 0.0610159" texDiv="256 256">
                            <Indices indices=" 25 24 22 23" />
                        </Face>
                        <Face id="12" plane="-0.768221 0 0.640184 -2.48672" album="Blasted" material="bm_beam_wood" texgens="-0.634398 0 -0.773006 128 0 1 0 127.651 90 0.0625 0.0610158" texRot="90" texScale="0.0625 0.0610158" texDiv="256 256">
                            <Indices indices=" 27 26 24 25" />
                        </Face>
                        <Face id="13" plane="-0.88148 0 0.472222 -2.48851" album="Blasted" material="bm_beam_wood" texgens="-0.471408 0 -0.881915 128 0 1 0 128.719 90 0.0625 0.062041" texRot="90" texScale="0.0625 0.062041" texDiv="256 256">
                            <Indices indices=" 29 28 26 27" />
                        </Face>
                        <Face id="14" plane="-0.957826 0 0.287348 -2.48885" album="Blasted" material="bm_beam_wood" texgens="-0.290276 0 -0.956943 128 0 1 0 130.025 90 0.0625 0.0611727" texRot="90" texScale="0.0625 0.0611727" texDiv="256 256">
                            <Indices indices=" 31 30 28 29" />
                        </Face>
                        <Face id="15" plane="-0.99535 0 0.0963242 -2.48837" album="Blasted" material="bm_beam_wood" texgens="-0.0980233 0 -0.995184 128 0 1 0 128.915 90 0.0625 0.0608299" texRot="90" texScale="0.0625 0.0608299" texDiv="256 256">
                            <Indices indices=" 33 32 30 31" />
                        </Face>
                        <Face id="16" plane="-0.99535 -0 -0.0963242 -2.48837" album="Blasted" material="bm_beam_wood" texgens="0.0980233 0 -0.995184 128 0 1 0 127.086 90 0.0625 0.0608299" texRot="90" texScale="0.0625 0.0608299" texDiv="256 256">
                            <Indices indices=" 35 34 32 33" />
                        </Face>
                        <Face id="17" plane="-0.957826 -0 -0.287348 -2.48885" album="Blasted" material="bm_beam_wood" texgens="0.290275 0 -0.956943 128 0 1 0 125.977 90 0.0625 0.0611726" texRot="90" texScale="0.0625 0.0611726" texDiv="256 256">
                            <Indices indices=" 37 36 34 35" />
                        </Face>
                        <Face id="18" plane="-0.88148 -0 -0.472222 -2.48851" album="Blasted" material="bm_beam_wood" texgens="0.471391 0 -0.881925 128 0 1 0 127.306 90 0.0625 0.0620409" texRot="90" texScale="0.0625 0.0620409" texDiv="256 256">
                            <Indices indices=" 39 38 36 37" />
                        </Face>
                        <Face id="19" plane="-0.768221 -0 -0.640184 -2.48672" album="Blasted" material="bm_beam_wood" texgens="0.634388 0 -0.773015 128 0 1 0 128.367 90 0.0625 0.0610158" texRot="90" texScale="0.0625 0.0610158" texDiv="256 256">
                            <Indices indices=" 41 40 38 39" />
                        </Face>
                        <Face id="20" plane="-0.640184 -0 -0.768221 -2.48672" album="Blasted" material="bm_beam_wood" texgens="0.773017 0 -0.634386 128 0 1 0 127.629 90 0.0625001 0.0610159" texRot="90" texScale="0.0625001 0.0610159" texDiv="256 256">
                            <Indices indices=" 43 42 40 41" />
                        </Face>
                        <Face id="21" plane="-0.472222 -0 -0.88148 -2.48851" album="Blasted" material="bm_beam_wood" texgens="0.881919 0 -0.471401 128 0 1 0 128.71 90 0.0625 0.0620408" texRot="90" texScale="0.0625 0.0620408" texDiv="256 256">
                            <Indices indices=" 45 44 42 43" />
                        </Face>
                        <Face id="22" plane="-0.287348 -0 -0.957826 -2.48885" album="Blasted" material="bm_beam_wood" texgens="0.956943 0 -0.290277 128 0 1 0 130.026 90 0.0625 0.0611727" texRot="90" texScale="0.0625 0.0611727" texDiv="256 256">
                            <Indices indices=" 47 46 44 45" />
                        </Face>
                        <Face id="23" plane="-0.0963242 -0 -0.99535 -2.48837" album="Blasted" material="bm_beam_wood" texgens="0.995184 0 -0.098023 128 0 1 0 128.914 90 0.0625 0.06083" texRot="90" texScale="0.0625 0.06083" texDiv="256 256">
                            <Indices indices=" 49 48 46 47" />
                        </Face>
                        <Face id="24" plane="0.0963242 0 -0.99535 -2.48837" album="Blasted" material="bm_beam_wood" texgens="0.995184 0 0.098023 128 0 1 0 127.086 90 0.0625 0.0608301" texRot="90" texScale="0.0625 0.0608301" texDiv="256 256">
                            <Indices indices=" 51 50 48 49" />
                        </Face>
                        <Face id="25" plane="0.287348 0 -0.957826 -2.48885" album="Blasted" material="bm_beam_wood" texgens="0.956943 0 0.290277 128 0 1 0 125.974 90 0.0625 0.0611727" texRot="90" texScale="0.0625 0.0611727" texDiv="256 256">
                            <Indices indices=" 53 52 50 51" />
                        </Face>
                        <Face id="26" plane="0.472222 0 -0.88148 -2.48851" album="Blasted" material="bm_beam_wood" texgens="0.881917 0 0.471405 128 0 1 0 127.285 90 0.0625 0.0620408" texRot="90" texScale="0.0625 0.0620408" texDiv="256 256">
                            <Indices indices=" 55 54 52 53" />
                        </Face>
                        <Face id="27" plane="0.640184 0 -0.768221 -2.48672" album="Blasted" material="bm_beam_wood" texgens="0.773007 0 0.634398 128 0 1 0 128.35 90 0.0625 0.0610159" texRot="90" texScale="0.0625 0.0610159" texDiv="256 256">
                            <Indices indices=" 57 56 54 55" />
                        </Face>
                        <Face id="28" plane="0.768221 0 -0.640184 -2.48672" album="Blasted" material="bm_beam_wood" texgens="0.634398 0 0.773007 128 0 1 0 127.65 90 0.0625 0.0610158" texRot="90" texScale="0.0625 0.0610158" texDiv="256 256">
                            <Indices indices=" 59 58 56 57" />
                        </Face>
                        <Face id="29" plane="0.88148 0 -0.472222 -2.48851" album="Blasted" material="bm_beam_wood" texgens="0.471386 0 0.881927 128 0 1 0 128.688 90 0.0625 0.0620409" texRot="90" texScale="0.0625 0.0620409" texDiv="256 256">
                            <Indices indices=" 61 60 58 59" />
                        </Face>
                        <Face id="30" plane="0.957826 0 -0.287348 -2.48885" album="Blasted" material="bm_beam_wood" texgens="0.290294 0 0.956938 128 0 1 0 130.049 90 0.0625 0.0611727" texRot="90" texScale="0.0625 0.0611727" texDiv="256 256">
                            <Indices indices=" 63 62 60 61" />
                        </Face>
                        <Face id="31" plane="0.99535 0 -0.0963242 -2.48837" album="Blasted" material="bm_beam_wood" texgens="0.0980055 0 0.995187 128 0 1 0 128.891 90 0.0625 0.0608301" texRot="90" texScale="0.0625 0.0608301" texDiv="256 256">
                            <Indices indices=" 63 3 2 62" />
                        </Face>
                        <Face id="32" plane="0 1 0 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -64 0 0 -1 320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 62 2 0 4 6 8 10 12 14 16 18 20 22 24 26 28 30 32 34 36 38 40 42 44 46 48 50 52 54 56 58 60" />
                        </Face>
                        <Face id="33" plane="-0 -1 0 -0.25" album="Blasted" material="bm_wood" texgens="1 0 0 -64 0 0 -1 320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 63 61 59 57 55 53 51 49 47 45 43 41 39 37 35 33 31 29 27 25 23 21 19 17 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="38" owner="0" type="0" pos="0 0.75 0" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 0.75 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="35" nextVertexID="65">
                        <Vertices>
                            <Vertex pos="2.45312 0.25 0.484378" />
                            <Vertex pos="2.45312 -0.25 0.484378" />
                            <Vertex pos="2.5 0.25 0" />
                            <Vertex pos="2.5 -0.25 0" />
                            <Vertex pos="2.3125 0.25 0.953122" />
                            <Vertex pos="2.3125 -0.25 0.953122" />
                            <Vertex pos="2.07812 0.25 1.39062" />
                            <Vertex pos="2.07812 -0.25 1.39062" />
                            <Vertex pos="1.76562 0.25 1.76562" />
                            <Vertex pos="1.76562 -0.25 1.76562" />
                            <Vertex pos="1.39062 0.25 2.07812" />
                            <Vertex pos="1.39062 -0.25 2.07812" />
                            <Vertex pos="0.953122 0.25 2.3125" />
                            <Vertex pos="0.953122 -0.25 2.3125" />
                            <Vertex pos="0.484378 0.25 2.45312" />
                            <Vertex pos="0.484378 -0.25 2.45312" />
                            <Vertex pos="0 0.25 2.5" />
                            <Vertex pos="0 -0.25 2.5" />
                            <Vertex pos="-0.484378 0.25 2.45312" />
                            <Vertex pos="-0.484378 -0.25 2.45312" />
                            <Vertex pos="-0.953122 0.25 2.3125" />
                            <Vertex pos="-0.953122 -0.25 2.3125" />
                            <Vertex pos="-1.39062 0.25 2.07812" />
                            <Vertex pos="-1.39062 -0.25 2.07812" />
                            <Vertex pos="-1.76562 0.25 1.76562" />
                            <Vertex pos="-1.76562 -0.25 1.76562" />
                            <Vertex pos="-2.07812 0.25 1.39062" />
                            <Vertex pos="-2.07812 -0.25 1.39062" />
                            <Vertex pos="-2.3125 0.25 0.953122" />
                            <Vertex pos="-2.3125 -0.25 0.953122" />
                            <Vertex pos="-2.45312 0.25 0.484378" />
                            <Vertex pos="-2.45312 -0.25 0.484378" />
                            <Vertex pos="-2.5 0.25 0" />
                            <Vertex pos="-2.5 -0.25 0" />
                            <Vertex pos="-2.45312 0.25 -0.484378" />
                            <Vertex pos="-2.45312 -0.25 -0.484378" />
                            <Vertex pos="-2.3125 0.25 -0.953122" />
                            <Vertex pos="-2.3125 -0.25 -0.953122" />
                            <Vertex pos="-2.07812 0.25 -1.39062" />
                            <Vertex pos="-2.07812 -0.25 -1.39062" />
                            <Vertex pos="-1.76562 0.25 -1.76562" />
                            <Vertex pos="-1.76562 -0.25 -1.76562" />
                            <Vertex pos="-1.39062 0.25 -2.07812" />
                            <Vertex pos="-1.39062 -0.25 -2.07812" />
                            <Vertex pos="-0.953122 0.25 -2.3125" />
                            <Vertex pos="-0.953122 -0.25 -2.3125" />
                            <Vertex pos="-0.484378 0.25 -2.45312" />
                            <Vertex pos="-0.484378 -0.25 -2.45312" />
                            <Vertex pos="0 0.25 -2.5" />
                            <Vertex pos="0 -0.25 -2.5" />
                            <Vertex pos="0.484378 0.25 -2.45312" />
                            <Vertex pos="0.484378 -0.25 -2.45312" />
                            <Vertex pos="0.953122 0.25 -2.3125" />
                            <Vertex pos="0.953122 -0.25 -2.3125" />
                            <Vertex pos="1.39062 0.25 -2.07812" />
                            <Vertex pos="1.39062 -0.25 -2.07812" />
                            <Vertex pos="1.76562 0.25 -1.76562" />
                            <Vertex pos="1.76562 -0.25 -1.76562" />
                            <Vertex pos="2.07812 0.25 -1.39062" />
                            <Vertex pos="2.07812 -0.25 -1.39062" />
                            <Vertex pos="2.3125 0.25 -0.953122" />
                            <Vertex pos="2.3125 -0.25 -0.953122" />
                            <Vertex pos="2.45312 0.25 -0.484378" />
                            <Vertex pos="2.45312 -0.25 -0.484378" />
                        </Vertices>
                        <Face id="0" plane="0.99535 -0 0.0963242 -2.48837" album="Blasted" material="bm_beam_wood" texgens="-0.0980232 0 0.995184 128 0 1 0 127.086 90 0.0625001 0.0608299" texRot="90" texScale="0.0625001 0.0608299" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.957826 0 0.287348 -2.48885" album="Blasted" material="bm_beam_wood" texgens="-0.290278 0 0.956942 128 0 1 0 125.972 90 0.0625 0.0611727" texRot="90" texScale="0.0625 0.0611727" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0.88148 0 0.472222 -2.48851" album="Blasted" material="bm_beam_wood" texgens="-0.471401 0 0.881919 128 0 1 0 127.291 90 0.0625 0.0620409" texRot="90" texScale="0.0625 0.0620409" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="0.768221 0 0.640184 -2.48672" album="Blasted" material="bm_beam_wood" texgens="-0.634386 0 0.773017 128 0 1 0 128.371 90 0.0625 0.0610158" texRot="90" texScale="0.0625 0.0610158" texDiv="256 256">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="0.640184 0 0.768221 -2.48672" album="Blasted" material="bm_beam_wood" texgens="-0.773017 0 0.634386 128 0 1 0 127.63 90 0.0625 0.0610158" texRot="90" texScale="0.0625 0.0610158" texDiv="256 256">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="0.472222 0 0.88148 -2.48851" album="Blasted" material="bm_beam_wood" texgens="-0.881922 0 0.471396 128 0 1 0 128.702 90 0.0625 0.062041" texRot="90" texScale="0.0625 0.062041" texDiv="256 256">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="0.287348 0 0.957826 -2.48885" album="Blasted" material="bm_beam_wood" texgens="-0.956943 0 0.290276 128 0 1 0 130.025 90 0.0625 0.0611727" texRot="90" texScale="0.0625 0.0611727" texDiv="256 256">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="0.0963242 0 0.99535 -2.48837" album="Blasted" material="bm_beam_wood" texgens="-0.995184 0 0.0980231 128 0 1 0 128.914 90 0.0625001 0.06083" texRot="90" texScale="0.0625001 0.06083" texDiv="256 256">
                            <Indices indices=" 17 16 14 15" />
                        </Face>
                        <Face id="8" plane="-0.0963242 0 0.99535 -2.48837" album="Blasted" material="bm_beam_wood" texgens="-0.995184 0 -0.0980232 128 0 1 0 127.086 90 0.0625001 0.0608299" texRot="90" texScale="0.0625001 0.0608299" texDiv="256 256">
                            <Indices indices=" 19 18 16 17" />
                        </Face>
                        <Face id="9" plane="-0.287348 0 0.957826 -2.48885" album="Blasted" material="bm_beam_wood" texgens="-0.956937 0 -0.290295 128 0 1 0 125.949 90 0.0625 0.0611727" texRot="90" texScale="0.0625 0.0611727" texDiv="256 256">
                            <Indices indices=" 21 20 18 19" />
                        </Face>
                        <Face id="10" plane="-0.472222 0 0.88148 -2.48851" album="Blasted" material="bm_beam_wood" texgens="-0.881927 0 -0.471387 128 0 1 0 127.311 90 0.0625 0.0620409" texRot="90" texScale="0.0625 0.0620409" texDiv="256 256">
                            <Indices indices=" 23 22 20 21" />
                        </Face>
                        <Face id="11" plane="-0.640184 0 0.768221 -2.48672" album="Blasted" material="bm_beam_wood" texgens="-0.773007 0 -0.634398 128 0 1 0 128.35 90 0.0625 0.0610159" texRot="90" texScale="0.0625 0.0610159" texDiv="256 256">
                            <Indices indices=" 25 24 22 23" />
                        </Face>
                        <Face id="12" plane="-0.768221 0 0.640184 -2.48672" album="Blasted" material="bm_beam_wood" texgens="-0.634398 0 -0.773006 128 0 1 0 127.651 90 0.0625001 0.0610158" texRot="90" texScale="0.0625001 0.0610158" texDiv="256 256">
                            <Indices indices=" 27 26 24 25" />
                        </Face>
                        <Face id="13" plane="-0.88148 0 0.472222 -2.48851" album="Blasted" material="bm_beam_wood" texgens="-0.471408 0 -0.881915 128 0 1 0 128.719 90 0.0625 0.062041" texRot="90" texScale="0.0625 0.062041" texDiv="256 256">
                            <Indices indices=" 29 28 26 27" />
                        </Face>
                        <Face id="14" plane="-0.957826 0 0.287348 -2.48885" album="Blasted" material="bm_beam_wood" texgens="-0.290276 0 -0.956943 128 0 1 0 130.025 90 0.0625 0.0611727" texRot="90" texScale="0.0625 0.0611727" texDiv="256 256">
                            <Indices indices=" 31 30 28 29" />
                        </Face>
                        <Face id="15" plane="-0.99535 0 0.0963242 -2.48837" album="Blasted" material="bm_beam_wood" texgens="-0.0980233 0 -0.995184 128 0 1 0 128.915 90 0.0625 0.0608299" texRot="90" texScale="0.0625 0.0608299" texDiv="256 256">
                            <Indices indices=" 33 32 30 31" />
                        </Face>
                        <Face id="16" plane="-0.99535 -0 -0.0963242 -2.48837" album="Blasted" material="bm_beam_wood" texgens="0.0980233 0 -0.995184 128 0 1 0 127.086 90 0.0625 0.0608299" texRot="90" texScale="0.0625 0.0608299" texDiv="256 256">
                            <Indices indices=" 35 34 32 33" />
                        </Face>
                        <Face id="17" plane="-0.957826 -0 -0.287348 -2.48885" album="Blasted" material="bm_beam_wood" texgens="0.290275 0 -0.956943 128 0 1 0 125.976 90 0.0625 0.0611726" texRot="90" texScale="0.0625 0.0611726" texDiv="256 256">
                            <Indices indices=" 37 36 34 35" />
                        </Face>
                        <Face id="18" plane="-0.88148 -0 -0.472222 -2.48851" album="Blasted" material="bm_beam_wood" texgens="0.471391 0 -0.881925 128 0 1 0 127.306 90 0.0625 0.0620409" texRot="90" texScale="0.0625 0.0620409" texDiv="256 256">
                            <Indices indices=" 39 38 36 37" />
                        </Face>
                        <Face id="19" plane="-0.768221 -0 -0.640184 -2.48672" album="Blasted" material="bm_beam_wood" texgens="0.634388 0 -0.773015 128 0 1 0 128.367 90 0.0625 0.0610158" texRot="90" texScale="0.0625 0.0610158" texDiv="256 256">
                            <Indices indices=" 41 40 38 39" />
                        </Face>
                        <Face id="20" plane="-0.640184 -0 -0.768221 -2.48672" album="Blasted" material="bm_beam_wood" texgens="0.773017 0 -0.634386 128 0 1 0 127.63 90 0.0625 0.0610158" texRot="90" texScale="0.0625 0.0610158" texDiv="256 256">
                            <Indices indices=" 43 42 40 41" />
                        </Face>
                        <Face id="21" plane="-0.472222 -0 -0.88148 -2.48851" album="Blasted" material="bm_beam_wood" texgens="0.881919 0 -0.471401 128 0 1 0 128.71 90 0.0625 0.0620408" texRot="90" texScale="0.0625 0.0620408" texDiv="256 256">
                            <Indices indices=" 45 44 42 43" />
                        </Face>
                        <Face id="22" plane="-0.287348 -0 -0.957826 -2.48885" album="Blasted" material="bm_beam_wood" texgens="0.956943 0 -0.290277 128 0 1 0 130.026 90 0.0625 0.0611727" texRot="90" texScale="0.0625 0.0611727" texDiv="256 256">
                            <Indices indices=" 47 46 44 45" />
                        </Face>
                        <Face id="23" plane="-0.0963242 -0 -0.99535 -2.48837" album="Blasted" material="bm_beam_wood" texgens="0.995184 0 -0.098023 128 0 1 0 128.914 90 0.0625001 0.06083" texRot="90" texScale="0.0625001 0.06083" texDiv="256 256">
                            <Indices indices=" 49 48 46 47" />
                        </Face>
                        <Face id="24" plane="0.0963242 0 -0.99535 -2.48837" album="Blasted" material="bm_beam_wood" texgens="0.995184 0 0.098023 128 0 1 0 127.086 90 0.0625 0.0608301" texRot="90" texScale="0.0625 0.0608301" texDiv="256 256">
                            <Indices indices=" 51 50 48 49" />
                        </Face>
                        <Face id="25" plane="0.287348 0 -0.957826 -2.48885" album="Blasted" material="bm_beam_wood" texgens="0.956943 0 0.290277 128 0 1 0 125.974 90 0.0625 0.0611727" texRot="90" texScale="0.0625 0.0611727" texDiv="256 256">
                            <Indices indices=" 53 52 50 51" />
                        </Face>
                        <Face id="26" plane="0.472222 0 -0.88148 -2.48851" album="Blasted" material="bm_beam_wood" texgens="0.881917 0 0.471405 128 0 1 0 127.285 90 0.0625 0.0620408" texRot="90" texScale="0.0625 0.0620408" texDiv="256 256">
                            <Indices indices=" 55 54 52 53" />
                        </Face>
                        <Face id="27" plane="0.640184 0 -0.768221 -2.48672" album="Blasted" material="bm_beam_wood" texgens="0.773007 0 0.634398 128 0 1 0 128.35 90 0.0625 0.0610159" texRot="90" texScale="0.0625 0.0610159" texDiv="256 256">
                            <Indices indices=" 57 56 54 55" />
                        </Face>
                        <Face id="28" plane="0.768221 0 -0.640184 -2.48672" album="Blasted" material="bm_beam_wood" texgens="0.634398 0 0.773007 128 0 1 0 127.65 90 0.0625 0.0610158" texRot="90" texScale="0.0625 0.0610158" texDiv="256 256">
                            <Indices indices=" 59 58 56 57" />
                        </Face>
                        <Face id="29" plane="0.88148 0 -0.472222 -2.48851" album="Blasted" material="bm_beam_wood" texgens="0.471386 0 0.881927 128 0 1 0 128.688 90 0.0625 0.0620409" texRot="90" texScale="0.0625 0.0620409" texDiv="256 256">
                            <Indices indices=" 61 60 58 59" />
                        </Face>
                        <Face id="30" plane="0.957826 0 -0.287348 -2.48885" album="Blasted" material="bm_beam_wood" texgens="0.290294 0 0.956938 128 0 1 0 130.049 90 0.0625 0.0611727" texRot="90" texScale="0.0625 0.0611727" texDiv="256 256">
                            <Indices indices=" 63 62 60 61" />
                        </Face>
                        <Face id="31" plane="0.99535 0 -0.0963242 -2.48837" album="Blasted" material="bm_beam_wood" texgens="0.0980055 0 0.995187 128 0 1 0 128.891 90 0.0625 0.0608301" texRot="90" texScale="0.0625 0.0608301" texDiv="256 256">
                            <Indices indices=" 63 3 2 62" />
                        </Face>
                        <Face id="32" plane="0 1 0 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -64 0 0 -1 320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 62 2 0 4 6 8 10 12 14 16 18 20 22 24 26 28 30 32 34 36 38 40 42 44 46 48 50 52 54 56 58 60" />
                        </Face>
                        <Face id="33" plane="-0 -1 0 -0.25" album="Blasted" material="bm_wood" texgens="1 0 0 -64 0 0 -1 320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 63 61 59 57 55 53 51 49 47 45 43 41 39 37 35 33 31 29 27 25 23 21 19 17 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                </Brushes>
            </InteriorMap>
        </DetailLevel>
    </DetailLevels>
</ConstructorScene>
